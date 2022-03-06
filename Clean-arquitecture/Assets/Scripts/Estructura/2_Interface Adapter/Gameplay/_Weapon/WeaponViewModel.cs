using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Utils;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponViewModel
    {
        private readonly WeaponConfiguration _configuration;

        private readonly string _id;
        private readonly string _name;
        private readonly float _attackRange;

        private Queue<int> _collisions;
        private List<Hero> _enemiesCollisions;
        private HeroInstanceAccess _heroInstanceRepository;
        private ReactiveProperty<bool> _doAttack;

        public WeaponViewModel(WeaponConfiguration configuration)
        {
            _configuration = configuration;

            _collisions = new Queue<int>();
          
            _enemiesCollisions = new List<Hero>();
            _heroInstanceRepository = ServiceLocator.Instance.GetService<HeroInstanceAccess>();

            _doAttack = new ReactiveProperty<bool>(default);
        }

        public string Id => _configuration.Id;
        public string Name => _configuration.WeaponData.Name;
        public int Damage => _configuration.WeaponData.Attributes.Damage;
        public float AttackRange => _configuration.WeaponData.Attributes.AttackRange;
        public int PenetrationRange => _configuration.WeaponData.Attributes.PenetrationRange;
        public float SecondsBetweenAttacks => _configuration.WeaponData.Attributes.SecondsBetweenAttacks;

        public Queue<int> Collisions { get => _collisions; }

        public ReactiveProperty<bool> DoAttack { get => _doAttack; set => _doAttack = value; }
    }
}
