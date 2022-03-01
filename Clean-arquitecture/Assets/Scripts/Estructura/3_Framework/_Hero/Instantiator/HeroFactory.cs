using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroFactory
    {
        private readonly HeroesConfiguration _heroesConfiguration;

        public HeroFactory(HeroesConfiguration heroesConfiguration)
        {
            _heroesConfiguration = heroesConfiguration;
        }


        public HeroView Create(HeroConfiguration heroConfiguration)
        {
            var prefab = _heroesConfiguration.GetHeroById(heroConfiguration.Id);
            var SpawnPosition = new Vector3(heroConfiguration.Position.X, heroConfiguration.Position.Y, heroConfiguration.Position.Z);

            return Object.Instantiate(prefab, SpawnPosition, Quaternion.identity);
        }
    }
}
