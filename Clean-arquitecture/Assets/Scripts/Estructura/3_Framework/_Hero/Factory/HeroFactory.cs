using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroFactory
    {
        private readonly HeroView _heroViewPrefab;

        public HeroFactory(HeroView heroViewPrefab)
        {
            _heroViewPrefab = heroViewPrefab;
        }
        public HeroView Create(HeroConfiguration heroConfiguration)
        {
            return Object.Instantiate(_heroViewPrefab);
        }
    }
}
