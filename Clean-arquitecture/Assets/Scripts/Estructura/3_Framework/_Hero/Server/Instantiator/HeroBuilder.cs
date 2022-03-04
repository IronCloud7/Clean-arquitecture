using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroBuilder
    {
        private string _id;
        private string _name;
        private HeroView _prefab;
        private Vector3 _position;
        private Quaternion _rotation;
        private Transform _parent;
        private Input _input;


        public HeroBuilder WithID(string id)
        {
            _id = id;
            return this;
        }

        public HeroBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public HeroBuilder WithPrefab(HeroView prefab)
        {
            _prefab = prefab;
            return this;
        }

        public HeroBuilder WithPosition(Vector3 position)
        {
            _position = position;
            return this;
        }

        public HeroBuilder WithRotation(Quaternion rotation)
        {
            _rotation = rotation;
            return this;
        }

        public HeroBuilder WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }

        public HeroBuilder WithInput(Input input)
        {
            _input = input;
            return this;
        }

        public HeroView Build()
        {
            var hero = Object.Instantiate(_prefab, _position, _rotation, _parent);
            
            return hero;
        }
    }
}
