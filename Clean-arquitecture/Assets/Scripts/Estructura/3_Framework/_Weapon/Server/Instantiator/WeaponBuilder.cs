using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class WeaponBuilder
    {
        private string _id;
        private string _name;
        private WeaponView _prefab;
        private Vector3 _position;
        private Quaternion _rotation;
        private Transform _parent;


        public WeaponBuilder WithID(string id)
        {
            _id = id;
            return this;
        }

        public WeaponBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public WeaponBuilder WithPrefab(WeaponView prefab)
        {
            _prefab = prefab;
            return this;
        }

        public WeaponBuilder WithPosition(Vector3 position)
        {
            _position = position;
            return this;
        }

        public WeaponBuilder WithRotation(Quaternion rotation)
        {
            _rotation = rotation;
            return this;
        }

        public WeaponBuilder WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }

        public WeaponView Build()
        {
            var weapon = Object.Instantiate(_prefab, _position, _rotation, _parent);

            return weapon;
        }
    }
}
