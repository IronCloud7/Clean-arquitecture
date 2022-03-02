using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class CheckGround : MonoBehaviour
    {
        [SerializeField] private LayerMask _whatIsGround;
        [SerializeField] private Transform _groundCheckPoint;
        [SerializeField] private bool _isGrounded;
        [SerializeField] private float _groundCheckRadius;

        public bool IsGrounded { get => _isGrounded; set => _isGrounded = value; }

        private void Update()
        {
            _isGrounded = Physics2D.OverlapCircle(_groundCheckPoint.position, _groundCheckRadius, _whatIsGround);
        }
    }
}
