using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class CheckGround : MonoBehaviour
    {
        private LayerMask _layer;

        private bool _isGround;
        public bool IsGround { get => _isGround; set => _isGround = value; }

        public void Awake()
        {
            _layer = LayerMask.GetMask("Ground");
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if ((_layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                IsGround = true;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if ((_layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                IsGround = false;
            }
        }

    }
}
