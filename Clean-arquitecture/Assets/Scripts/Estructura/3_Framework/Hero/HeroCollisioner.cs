using Assets.Scripts.Estructura._2_Interface_Adapter.Hero;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework.Hero
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
                // _heroColisionerModel.IsGround.Value = true;
                _heroColisionerModel.IsGround = true;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if ((_layer.value & (1 << collision.gameObject.layer)) > 0)
            {
                // _heroColisionerModel.IsGround.Value = false;
                _heroColisionerModel.IsGround = false;
            }
        }

    }
}
