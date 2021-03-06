using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Weapon/Data/Data", fileName = "Weapon Data")]
    public class WeaponUnity : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private string _name;
        [SerializeField] private int _damage;
        [SerializeField] private float _attackRange;
        [SerializeField] private int _penetrationRange;
        [SerializeField] private float _secondsBetweenAttacks;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public float AttackRange { get => _attackRange; set => _attackRange = value; }
        public int PenetrationRange { get => _penetrationRange; set => _penetrationRange = value; }
        public float SecondsBetweenAttacks { get => _secondsBetweenAttacks; set => _secondsBetweenAttacks = value; }
    }
}
