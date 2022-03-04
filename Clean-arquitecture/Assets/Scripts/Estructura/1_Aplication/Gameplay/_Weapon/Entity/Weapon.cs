
using System.Numerics;

namespace Assets.Scripts.Estructura._1_Aplication
{
    public class Weapon
    {
        private readonly int _instanceId;
        private readonly WeaponData _weaponData;
        private Vector3 _position;

        public int InstanceId => _instanceId;
        public WeaponData WeaponData => _weaponData;
        public Vector3 Position => _position;

        public Weapon(WeaponData weaponData, int instanceId, Vector3 position)
        {
            _instanceId = instanceId;
            _weaponData = weaponData;
            _position = position;
        }
    }

}
