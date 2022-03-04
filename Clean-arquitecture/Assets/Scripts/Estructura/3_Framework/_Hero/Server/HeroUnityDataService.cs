using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Utils;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroUnityDataService : MonoBehaviour, HeroDataService
    {
        [SerializeField] private HeroUnityCollection _heroesData;

        public void Awake()
        {
            _heroesData = Instantiate(_heroesData);
        }

        public HeroRaw GetHero(string id)
        {
            var heroUnity = _heroesData.GetHeroById(id);

            var heroRaw = new HeroRaw();
            heroRaw.Id = heroUnity.Id;
            heroRaw.Name = heroUnity.Name;
            heroRaw.Weapon = heroUnity.Weapon;
            heroRaw.WeaponSpawnerReference = heroUnity.WeaponSpawnerReference.ToNumerics();
            heroRaw.Health = heroUnity.Health;
            heroRaw.MovementSpeed = heroUnity.MovementSpeed;
            heroRaw.RunSpeed = heroUnity.RunSpeed;
            heroRaw.JumpVelocity = heroUnity.JumpVelocity;
            heroRaw.SecondsBetweenJumps = heroUnity.SecondsBetweenJumps;

            return heroRaw;
        }
    }
}
