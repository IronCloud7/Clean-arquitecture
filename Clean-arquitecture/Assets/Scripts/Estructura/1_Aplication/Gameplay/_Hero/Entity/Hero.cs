using System;
using System.Numerics;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class Hero
    {
        private readonly int _instanceId;
        private readonly HeroData _heroData;
        private readonly WeaponData _weapon;
        private int _maxHealth;
        private int _currentHealth;
        private Vector3 _position;

        private long _lastAttackTime;
        private long _lastJumpTime;
        private float _secondsBetweenJumps;

        public int InstanceId => _instanceId;
        public HeroData HeroData => _heroData;
        public Vector3 Position { get => _position; set => _position = value; }
        public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
   
        public Hero(HeroData hero, int instanceId, Vector3 position)
        {
            _instanceId = instanceId;
            _heroData = hero;
            _position = position;
            _weapon = new WeaponData(); //_hero.Attributes.Weapon;
            _maxHealth = hero.Attributes.Health;
            _currentHealth = _heroData.Attributes.Health;
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
            if (run) return HeroData.Attributes.RunSpeed * deltaTime * direction;
            return HeroData.Attributes.MovementSpeed * deltaTime * direction;
        }

        public void Attack()
        {
            _lastAttackTime = DateTime.Now.Ticks;
        }

        public int Jump()
        {
            _lastJumpTime = DateTime.Now.Ticks;

            return HeroData.Attributes.JumpVelocity;
        }

        private bool IsAttacking()
        {
            return _lastAttackTime + TimeSpan.FromSeconds(_weapon.SecondsBetweenAttacks).Ticks > DateTime.Now.Ticks;
        }

        private bool IsJumping()
        {
            return _lastJumpTime + TimeSpan.FromSeconds(_heroData.Attributes.SecondsBetweenJumps).Ticks > DateTime.Now.Ticks;
        }


        public bool ReceiveDamage(Hero enemy)
        {
            CurrentHealth -= enemy._weapon.Damage;
            return CurrentHealth <= 0;
        }
    }
}