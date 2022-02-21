using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Hero Data")]
    public class HeroData : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private string _name;
        [SerializeField] private string _weaponId;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string WeaponId { get => _weaponId; set => _weaponId = value; }
    }
}
