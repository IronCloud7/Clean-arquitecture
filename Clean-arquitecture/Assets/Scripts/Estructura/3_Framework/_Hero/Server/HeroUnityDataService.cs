using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

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
            var heroData = _heroesData.GetHeroById(id);

            var heroResult = new HeroRaw();
            heroResult.Id = heroData.Id;
            heroResult.Name = heroData.Name;
            heroResult.Posicion = new System.Numerics.Vector3(heroData.Position.x, heroData.Position.y, heroData.Position.z);
            heroResult.Weapon = heroData.Weapon;
            heroResult.Health = heroData.Health;
            heroResult.MovementSpeed = heroData.MovementSpeed;
            heroResult.RunSpeed = heroData.RunSpeed;
            heroResult.JumpVelocity = heroData.JumpVelocity;
            heroResult.SecondsBetweenJumps = heroData.SecondsBetweenJumps;

            return heroResult;
        }
    }
}
