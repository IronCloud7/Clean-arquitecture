using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework.Weapon.Data
{
    [CreateAssetMenu(menuName = "Custom/Weapon Data")]
    public class WeaponData : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private string _nombre;
        [SerializeField] private float _danyo;

        public string Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public float Danyo { get => _danyo; set => _danyo = value; }
    }
}
