using Assets.Scripts.Utils;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponViewModel
    {
        private readonly WeaponConfiguration _configuration;

        private readonly string _id;
        private readonly string _name;
        private readonly float _attackRange;

        public WeaponViewModel(WeaponConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Id => _configuration.Id;
        public string Name => _configuration.WeaponData.Name;
        public int Damage => _configuration.WeaponData.Attributes.Damage;
        public float AttackRange => _configuration.WeaponData.Attributes.AttackRange;
        public float SecondsBetweenAttacks => _configuration.WeaponData.Attributes.SecondsBetweenAttacks;
    }
}
