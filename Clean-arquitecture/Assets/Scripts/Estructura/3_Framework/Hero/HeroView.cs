using Assets.Scripts.Estructura._2_Interface_Adapter.Hero;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework.Hero
{
    public class HeroView : MonoBehaviour
    {
        private HeroViewModel _heroViewModel;

        [SerializeField] private readonly float _jump = 10;
        [SerializeField] private readonly float _velocity = 4;

        private Rigidbody2D _rigidbody;

        public void Configure(HeroViewModel heroViewModel)
        {
            _heroViewModel = heroViewModel;

            //Suscripciones
            _heroViewModel.HorizontalAxis.Subscribe(UpdateMove);
            _heroViewModel.VerticalAxis.Subscribe(UpdateMove);
            _heroViewModel.Jump.Subscribe(UpdateJump);

            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void UpdateMove()
        {
            var direction = new Vector3(_heroViewModel.HorizontalAxis.Value, default, default).normalized;
            transform.Translate(direction * (_velocity * Time.deltaTime));
        }

        public void UpdateJump()
        {
            _rigidbody.velocity = Vector3.up * _jump;
        }
        public void OnDestroy()
        {
            //Desuscripciones
            _heroViewModel.HorizontalAxis.Unsubscribe(UpdateMove);
            _heroViewModel.VerticalAxis.Unsubscribe(UpdateMove);
            _heroViewModel.Jump.Unsubscribe(UpdateJump);
        }
    }
}
