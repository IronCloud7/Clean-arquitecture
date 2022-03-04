using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class SwordView : WeaponView
    {
        [SerializeField] private LayerMask _whatIsEnemy;

        private Collider2D[] _checkedEnemies;
        private SpriteRenderer atacante;

        public Collider2D[] CheckedEnemies { get => _checkedEnemies; set => _checkedEnemies = value; }

        private void Start()
        {
            atacante = transform.parent.GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            Vector3 direction = atacante.flipX ? -transform.right : transform.right;

            _checkedEnemies = Physics2D.OverlapCircleAll(transform.position, _modelView.AttackRange , _whatIsEnemy);

            Debug.Log(_checkedEnemies.Length.ToString());
            foreach (Collider2D enemy in _checkedEnemies)
            {
                Debug.Log(enemy.name.ToString());
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (transform.position == null) return;

            Gizmos.DrawWireSphere(transform.position, _modelView.AttackRange);
        }
    }
}
