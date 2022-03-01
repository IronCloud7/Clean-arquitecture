using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Data/Heroes Data")]
    public class HeroesData : ScriptableObject
    {
        [SerializeField] private HeroData[] _heroes;
        private Dictionary<string, HeroData> _idToHero;

        public HeroData[] Heroes => _heroes;

        public void Awake()
        {
            _idToHero = new Dictionary<string, HeroData>();
            foreach (var hero in _heroes)
            {
                _idToHero.Add(hero.Id, hero);
            }
        }

        public HeroData GetHeroById(string id)
        {
            if (!_idToHero.TryGetValue(id, out var heroData))
            {
                throw new ArgumentOutOfRangeException($"Hero with Id {id} does not exist");
            }

            return heroData;
        }

    }
}
