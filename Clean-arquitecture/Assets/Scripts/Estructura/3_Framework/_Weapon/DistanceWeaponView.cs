using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class DistanceWeaponView : WeaponView
    {
        [SerializeField] private LayerMask _whatIsEnemy;

        private RaycastHit2D[] _checkedEnemies;
        private SpriteRenderer atacante;

        public RaycastHit2D[] CheckedEnemies { get => _checkedEnemies; set => _checkedEnemies = value; }

        private void Start()
        {
            atacante = transform.parent.GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            Vector3 direction = atacante.flipX ? -transform.right : transform.right;

            _checkedEnemies = Physics2D.RaycastAll(transform.position, direction, _modelView.AttackRange, _whatIsEnemy);

            Debug.Log(_checkedEnemies.Length.ToString());
            foreach (RaycastHit2D enemy in _checkedEnemies)
            {
                Debug.Log(enemy.collider.name);
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (transform.position == null) return;

            Vector3 direction = atacante.flipX ? -transform.right : transform.right;
            Gizmos.DrawLine(transform.position, transform.position + (direction * _modelView.AttackRange));
        }
    }
}
