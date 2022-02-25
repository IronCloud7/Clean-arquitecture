using Assets.Scripts.Estructura._2_Interface_Adapter;
using System;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroView : MonoBehaviour
    {
        private HeroViewModel _heroViewModel;

        [SerializeField] private float _jump = 20;
        [SerializeField] private float _velocity = 3;

        private Rigidbody2D _rigidbody;
        private Animator _animator;
        private SpriteRenderer _spriteRenderer;

        public void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }
        public void Configure(HeroViewModel heroViewModel)
        {
            _heroViewModel = heroViewModel;

            //Suscripciones
            _heroViewModel.HorizontalAxis.Subscribe(UpdateMove);
            _heroViewModel.VerticalAxis.Subscribe(UpdateMove);
            _heroViewModel.Jump.Subscribe(UpdateJump);
        }
        public void OnDestroy()
        {
            //Desuscripciones
            _heroViewModel.HorizontalAxis.Unsubscribe(UpdateMove);
            _heroViewModel.VerticalAxis.Unsubscribe(UpdateMove);
            _heroViewModel.Jump.Unsubscribe(UpdateJump);
        }

        public void UpdateMove()
        {
            var direction = new Vector3(_heroViewModel.HorizontalAxis.Value, default, default).normalized;

            Flip(direction);
            Run(direction);
     
            transform.Translate(direction * (_velocity * Time.deltaTime));
        }

        private void Flip(Vector3 direction)
        {
            if (direction.x > 0)
            {
                _spriteRenderer.flipX = false;
            }
            else if(direction.x < 0)
            {
                _spriteRenderer.flipX = true;
            }
        }

        private void Run(Vector3 direction)
        {
            if (direction.Equals(Vector3.zero))
            {
                _animator.SetBool("walking", false);
                _animator.SetBool("running", false);
            }else{
                _animator.SetBool("walking", false);
                _animator.SetBool("running", true);
            }                         
        }

        public void UpdateJump()
        {
            _animator.SetTrigger("jump");
            _rigidbody.velocity = Vector3.up * _jump;
        }
    }
}
