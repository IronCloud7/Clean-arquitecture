using System.Numerics;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class HeroData
    {
        private string _id;
        private string _name;
        private string _input;
        private Vector3 _posicion;
        private HeroAttributes _attributes;

        public HeroData()
        {
            _attributes = new HeroAttributes();
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Input { get => _input; set => _input = value; }
        public Vector3 Posicion { get => _posicion; set => _posicion = value; }
        public HeroAttributes Attributes { get => _attributes; set => _attributes = value; }

        public class HeroAttributes
        {
            private string _weapon;
            private int _health;
            private int _movementSpeed;
            private int _runSpeed;
            private int _jumpVelocity;
            private float _secondsBetweenJumps;

            public string Weapon { get => _weapon; set => _weapon = value; }
            public int Health { get => _health; set => _health = value; }
            public int MovementSpeed { get => _movementSpeed; set => _movementSpeed = value; }
            public int JumpVelocity { get => _jumpVelocity; set => _jumpVelocity = value; }
            public int RunSpeed { get => _runSpeed; set => _runSpeed = value; }
            public float SecondsBetweenJumps { get => _secondsBetweenJumps; set => _secondsBetweenJumps = value; }
        }
    }
}

