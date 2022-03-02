using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Weapon/Data/Data", fileName = "Weapon Data")]
    public class WeaponUnity : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private string _name;
        [SerializeField] private int _damage;
        [SerializeField] private float attackRange;
        [SerializeField] private float secondsBetweenAttacks;
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public float AttackRange { get => attackRange; set => attackRange = value; }
        public float SecondsBetweenAttacks { get => secondsBetweenAttacks; set => secondsBetweenAttacks = value; }
    }
}
