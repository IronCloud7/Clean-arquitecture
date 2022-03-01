using Assets.Scripts.Estructura._2_Interface_Adapter;
using System;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroView : MonoBehaviour
    {
        private HeroViewModel _heroViewModel;
      
        private Rigidbody2D _rigidbody;
        private Animator _animator;
        private SpriteRenderer _spriteRenderer;

        private Input _input;
        private CheckGround _groundCheck;

        public void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _groundCheck = GetComponent<CheckGround>();
            _input = new UnityInputAdapter();
        }
        public void Configure(HeroViewModel heroViewModel)
        {
            _heroViewModel = heroViewModel;         
            _heroViewModel.Movement.Subscribe(UpdateMove);
            _heroViewModel.JumpVelocity.Subscribe(UpdateJump);
            _heroViewModel.DoAttack.Subscribe(UpdateAttack);
        }

        private void OnDestroy()
        {
            _heroViewModel.Movement.Unsubscribe(UpdateMove);
            _heroViewModel.JumpVelocity.Unsubscribe(UpdateJump);
            _heroViewModel.DoAttack.Unsubscribe(UpdateAttack);
        }

        public void Update()
        {
            Timers();
            Collisions();
            Controls();
        }

        private void Controls()
        {
            if (_input.Button1()) _heroViewModel.Button1Pressed.Execute();
            if (_input.Button2()) _heroViewModel.Button2Pressed.Execute();
            if (_input.Button3()) _heroViewModel.Button3Pressed.Execute();
            if (_input.Button4()) _heroViewModel.Button4Pressed.Execute();
            if (_input.Button5()) _heroViewModel.Button5Pressed.Execute();
            if (_input.Button6()) _heroViewModel.Button6Pressed.Execute();
            if (_input.Button7()) _heroViewModel.Button7Pressed.Execute();
            if (_input.Button8()) _heroViewModel.Button8Pressed.Execute();

            _heroViewModel.IsRunning = _input.Button2();
            _heroViewModel.HAxisPressed.Value = _input.HAxis();
            _heroViewModel.VAxisPressed.Value = _input.VAxis();
        }
        private void Timers()
        {
            _heroViewModel.DeltaTime = Time.deltaTime;        
        }
        private void Collisions()
        {
            _heroViewModel.IsGround = _groundCheck.IsGround;
        }

        public void UpdateMove()
        {
            var move = new Vector3(_heroViewModel.Movement.Value , default, default);

            Flip();
            Run();

            transform.Translate(move);
        }

        private void Flip()
        {
            var direction = _heroViewModel.HAxisPressed.Value;
            if (direction > 0)
            {
                _spriteRenderer.flipX = false;
            }
            else if(direction < 0)
            {
                _spriteRenderer.flipX = true;
            }
        }
        private void Run()
        {
     

            var direction = _heroViewModel.HAxisPressed.Value;
            if (direction == 0)
            {
                ResetAnimations();           
            }
            else
            {
                if (!_heroViewModel.IsRunning)
                {
                    _animator.SetBool("running", false);
                    _animator.SetBool("walking", true);
                }      
                else
                {
                    _animator.SetBool("walking", false);
                    _animator.SetBool("running", true); 
                }             
           }                   
        }

        public void UpdateJump()
        {
            ResetAnimations();

            _animator.SetTrigger("jump");
            _rigidbody.velocity = Vector3.up * _heroViewModel.JumpVelocity.Value;
        }

        public void UpdateAttack()
        {
            ResetAnimations();

            if (_heroViewModel.DoAttack.Value)
                _animator.SetTrigger("attack");
        }

        public void ResetAnimations()
        {
            _animator.SetBool("walking", false);
            _animator.SetBool("running", false);
        }

    }
}
