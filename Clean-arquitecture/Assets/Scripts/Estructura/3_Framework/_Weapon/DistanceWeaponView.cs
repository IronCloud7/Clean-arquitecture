using Assets.Scripts.Estructura._2_Interface_Adapter;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class DistanceWeaponView : WeaponView
    {
        private RaycastHit2D[] _raycastHits;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void OnDrawGizmosSelected()
        {
            if (_transform.position == null) return;

            var direction = _transform.parent.localScale.x == 1 ? _transform.right : -_transform.right;

            Gizmos.color = Color.red;
            Gizmos.DrawRay(_transform.position, direction * _weaponViewModel.AttackRange);    
        }

        protected override void UpdateAttack()
        {
            _weaponViewModel.Collisions.Clear();

            var direction = _transform.parent.localScale.x == 1 ? _transform.right : -_transform.right;

            _raycastHits = Physics2D.RaycastAll(_transform.position, direction, _weaponViewModel.AttackRange);

            int hitEffects = 0;
            foreach (RaycastHit2D hit in _raycastHits)
            {
                if (hit.collider == null) continue;

                if (hitEffects >= _weaponViewModel.PenetrationRange)
                    break;

                if (hit.collider.gameObject.layer.Equals(_whatIsEnemy))
                {
                    _weaponViewModel.Collisions.Enqueue(hit.collider.gameObject.GetInstanceID());
                }

                Instantiate(_impact, hit.transform.position, Quaternion.identity);

                hitEffects++;
            }
        }
    }
}
