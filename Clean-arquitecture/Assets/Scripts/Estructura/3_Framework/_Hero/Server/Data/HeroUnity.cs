using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Hero/Data/Data", fileName = "Hero Data")]
    public class HeroUnity : ScriptableObject
    {
        [SerializeField] private string _id;

        [SerializeField] private string _name;
        [SerializeField] private string _weapon;
        [SerializeField] private Vector3 _weaponSpawnerReference;
        [SerializeField] private int _health;
        [SerializeField] private int _movementSpeed;
        [SerializeField] private int _runSpeed;
        [SerializeField] private int _jumpVelocity;
        [SerializeField] private float _secondsBetweenJumps;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Weapon { get => _weapon; set => _weapon = value; }
        public Vector3 WeaponSpawnerReference { get => _weaponSpawnerReference; set => _weaponSpawnerReference = value; }
        public int Health { get => _health; set => _health = value; }
        public int MovementSpeed { get => _movementSpeed; set => _movementSpeed = value; }
        public int RunSpeed { get => _runSpeed; set => _runSpeed = value; }
        public int JumpVelocity { get => _jumpVelocity; set => _jumpVelocity = value; }
        public float SecondsBetweenJumps { get => _secondsBetweenJumps; set => _secondsBetweenJumps = value; }
 
    }
}
