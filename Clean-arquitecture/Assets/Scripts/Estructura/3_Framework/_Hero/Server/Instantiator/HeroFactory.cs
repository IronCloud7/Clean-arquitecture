using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Utils;
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
            var position = heroConfiguration.Position.ToUnity();

            HeroBuilder heroBuilder = new HeroBuilder();
            heroBuilder.WithID(heroConfiguration.Id);
            heroBuilder.WithPrefab(prefab);
            heroBuilder.WithPosition(position);
            heroBuilder.WithRotation(Quaternion.identity);

            return heroBuilder.Build();
        }
    }
}
