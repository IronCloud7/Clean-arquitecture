using Assets.Scripts.Estructura._1_Aplication;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class WeaponConfiguration
    {
        private readonly Vector3 _position;
        private readonly WeaponData _weaponData;

        public WeaponConfiguration(WeaponData weaponData, Vector3 position)
        {
            _weaponData = weaponData;
            _position = position;
        }

        public string Id => _weaponData.Id;
        public WeaponData WeaponData => _weaponData;
        public Vector3 Position => _position;

    }
}
