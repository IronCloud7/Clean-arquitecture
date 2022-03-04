using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class CheckEnemy : MonoBehaviour
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
            Vector3 direccion;
            if (atacante.flipX) direccion = -transform.right; 
            else direccion = transform.right;

            _checkedEnemies = Physics2D.RaycastAll(transform.position, direccion, 20, _whatIsEnemy);

            Debug.DrawLine(transform.position, transform.position + (direccion * 20),Color.red);
            Debug.Log(_checkedEnemies.Length.ToString());         
        }


    }
}
