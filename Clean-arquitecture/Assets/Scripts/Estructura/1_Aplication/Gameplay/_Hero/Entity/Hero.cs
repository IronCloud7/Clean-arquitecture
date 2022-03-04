using System;
using System.Numerics;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class Hero
    {
        private readonly int _instanceId;
        private readonly HeroData _heroData;
        private Vector3 _position;

        private Weapon _weapon;
        private int _currentHealth;
     
        private long _lastAttackTime;
        private long _lastJumpTime;

        public int InstanceId => _instanceId;
        public HeroData HeroData => _heroData;
        public Vector3 Position { get => _position; set => _position = value; }
        public int CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
    
        public Hero(HeroData heroData, int instanceId, Vector3 position)
        {        
            _instanceId = instanceId;
            _heroData = heroData;
            _position = position;

            _currentHealth = _heroData.Attributes.Health;
        }

        public void SetWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }
        public bool CanMove()
        {
            return !IsAttacking();
        }

        public bool CanAttack()
        {
            if (IsAttacking())
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
            return _lastAttackTime + TimeSpan.FromSeconds(_weapon.WeaponData.Attributes.SecondsBetweenAttacks).Ticks > DateTime.Now.Ticks;
        }

        private bool IsJumping()
        {
            return _lastJumpTime + TimeSpan.FromSeconds(_heroData.Attributes.SecondsBetweenJumps).Ticks > DateTime.Now.Ticks;
        }


        public bool ReceiveDamage(Hero enemy)
        {
            CurrentHealth -= enemy._weapon.WeaponData.Attributes.Damage;
            return CurrentHealth <= 0;
        }
    }
}