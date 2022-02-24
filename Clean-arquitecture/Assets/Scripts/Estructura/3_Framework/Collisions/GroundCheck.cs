using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class GroundCheck : MonoBehaviour
    {
        [SerializeField] private LayerMask _layer;

        private GroundModel _groundCheck;
        public void Configure(GroundModel groundCheck)
        {
            _groundCheck = groundCheck;
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if ((_layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                _groundCheck.IsGround = true;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if ((_layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                _groundCheck.IsGround = false;
            }
        }

    }
}
