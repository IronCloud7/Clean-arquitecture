using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroFactory
    {
        private readonly HeroPrefabCollection _heroPrefabCollection;

        public HeroFactory(HeroPrefabCollection heroesConfiguration)
        {
            _heroPrefabCollection = heroesConfiguration;
        }


        public HeroView Create(HeroConfiguration heroConfiguration)
        {
            var prefab = _heroPrefabCollection.GetHeroById(heroConfiguration.Id);
            var SpawnPosition = new Vector3(heroConfiguration.Position.X, heroConfiguration.Position.Y, heroConfiguration.Position.Z);

            return Object.Instantiate(prefab, SpawnPosition, Quaternion.identity);
        }
    }
}
