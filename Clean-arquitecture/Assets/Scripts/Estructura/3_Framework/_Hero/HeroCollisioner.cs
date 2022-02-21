using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroCollisioner : MonoBehaviour
    {
        [SerializeField] private LayerMask _layer;

        private HeroColisionerModel _heroColisionerModel;
        public void Configure(HeroColisionerModel heroColisionerModel)
        {
            _heroColisionerModel = heroColisionerModel;
        }
        public void OnCollisionEnter2D(Collision2D collision)
        {

            if ((_layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                _heroColisionerModel.IsGround = true;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if ((_layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                _heroColisionerModel.IsGround = false;
            }
        }

    }
}
