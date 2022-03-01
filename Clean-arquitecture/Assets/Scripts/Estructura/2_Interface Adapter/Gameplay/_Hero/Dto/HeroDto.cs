
using Assets.Scripts.Estructura._1_Aplication;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroDto
    {
        private string _id;
        private string _name;
        private Vector3 _posicion;
        private string _weapon;
        private int _health;
        private int _attack;
        private int _movementSpeed;
        private int _runSpeed;
        private int _jumpVelocity;
        private float _secondsBetweenJumps;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public Vector3 Posicion { get => _posicion; set => _posicion = value; }
        public string Weapon { get => _weapon; set => _weapon = value; }
        public int Health { get => _health; set => _health = value; }
        public int Attack { get => _attack; set => _attack = value; }
        public int MovementSpeed { get => _movementSpeed; set => _movementSpeed = value; }
        public int RunSpeed { get => _runSpeed; set => _runSpeed = value; }
        public int JumpVelocity { get => _jumpVelocity; set => _jumpVelocity = value; }
        public float SecondsBetweenJumps { get => _secondsBetweenJumps; set => _secondsBetweenJumps = value; }
    }

}
