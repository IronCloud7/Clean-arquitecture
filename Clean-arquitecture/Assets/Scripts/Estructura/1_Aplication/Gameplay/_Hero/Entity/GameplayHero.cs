using System;
using System.Numerics;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class GameplayHero
    {
        private readonly int _instanceId;
        private readonly Hero _hero;
        private readonly Weapon _weapon;
        private int _maxHealth;
        private int _currentHealth;
        private Vector3 _position;

        private long _lastAttackTime;
        private long _lastJumpTime;
        private float _secondsBetweenJumps;

        public int InstanceId => _instanceId;
        public Hero Hero => _hero;
        public Vector3 Position { get => _position; set => _position = value; }
        public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
   
        public GameplayHero(Hero hero, int instanceId, Vector3 position)
        {
            _instanceId = instanceId;
            _hero = hero;
            _position = position;
            _weapon = new Weapon(); //_hero.Attributes.Weapon;
            _maxHealth = hero.Attributes.Health;
            _currentHealth = _hero.Attributes.Health;
            _weapon.SecondsBetweenAttacks = 0.6f; 
   
            _lastAttackTime = 0;
            _lastJumpTime = 0;      
        }

        public bool CanMove()
        {
            return !IsAttacking();
        }

        public bool CanAttack()
        {
            if (IsAttacking() /*|| IsJumping()*/)
            {
                return false;
            }

            return true;
        }  

        public bool CanJump()
        {
            if (IsAttacking() || IsJumping())
            {
                return false;
            }

            return true;
        }

        public float Move(float direction, float deltaTime, bool run)
        {
            if (run) return Hero.Attributes.RunSpeed * deltaTime * direction;
            return Hero.Attributes.MovementSpeed * deltaTime * direction;
        }

        public void Attack()
        {
            _lastAttackTime = DateTime.Now.Ticks;
        }

        public int Jump()
        {
            _lastJumpTime = DateTime.Now.Ticks;

            return Hero.Attributes.JumpVelocity;
        }

        private bool IsAttacking()
        {
            return _lastAttackTime + TimeSpan.FromSeconds(_weapon.SecondsBetweenAttacks).Ticks > DateTime.Now.Ticks;
        }

        private bool IsJumping()
        {
            return _lastJumpTime + TimeSpan.FromSeconds(_hero.Attributes.SecondsBetweenJumps).Ticks > DateTime.Now.Ticks;
        }


        public bool ReceiveDamage(GameplayHero enemy)
        {
            CurrentHealth -= enemy._weapon.Damage;
            return CurrentHealth <= 0;
        }
    }
}