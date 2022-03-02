using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Hero/Data/Collection", fileName = "Hero Data Collection")]
    public class HeroUnityCollection : ScriptableObject
    {
        [SerializeField] private HeroUnity[] _heroes;
        private Dictionary<string, HeroUnity> _idToHero;

        public HeroUnity[] Heroes => _heroes;

        public void Awake()
        {
            _idToHero = new Dictionary<string, HeroUnity>();
            foreach (var hero in _heroes)
            {
                _idToHero.Add(hero.Id, hero);
            }
        }

        public HeroUnity GetHeroById(string id)
        {
            if (!_idToHero.TryGetValue(id, out var heroUnityData))
            {
                throw new ArgumentOutOfRangeException($"Hero with Id {id} does not exist");
            }

            return heroUnityData;
        }

    }
}
