using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class MeleWeaponView : WeaponView
    {
        private Collider2D[] _collidersHits;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void OnDrawGizmosSelected()
        {
            if (transform.position == null) return;

            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, _weaponViewModel.AttackRange);
        }

        protected override void UpdateAttack()
        {
            _weaponViewModel.Collisions.Clear();

            _collidersHits = Physics2D.OverlapCircleAll(transform.position, _weaponViewModel.AttackRange, _whatIsEnemy);

            int hitEffects = 0;
            foreach (Collider2D hit in _collidersHits)
            {
                if (hitEffects >= _weaponViewModel.PenetrationRange)
                    break;

                if (hit.transform.gameObject.layer.Equals(_whatIsEnemy))
                {
                    _weaponViewModel.Collisions.Enqueue(hit.gameObject.GetInstanceID());
                }

                Instantiate(_impact, hit.transform.position, Quaternion.identity);

                hitEffects++;
            }
        }
    }
}
