using Assets.Scripts.Estructura._2_Interface_Adapter.Hero;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework.Hero
{
    public class HeroColisioner : MonoBehaviour
    {
        [SerializeField] private LayerMask _layer;

        private HeroColisionerModel _heroColisionerModel;
        public void Configure(HeroColisionerModel heroColisionerModel)
        {
            _heroColisionerModel = heroColisionerModel;
        }
        public void OnCollisionEnter2D(Collision2D collision)
        {
            _heroColisionerModel.IsGround.Value = false;
            if (collision.gameObject.layer.Equals(_layer.value))
            {
                _heroColisionerModel.IsGround.Value = true;
            }
        }
    }
}
