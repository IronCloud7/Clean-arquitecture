using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    [CreateAssetMenu(menuName = "Custom/Hero/Prefab/Collection", fileName = "Hero Prefab Collection")]
    public class HeroPrefabCollection : ScriptableObject
    {
        [SerializeField] private HeroView[] _heroes;
        private Dictionary<int, HeroView> _idToHero;

        public HeroView[] Heroes => _heroes;

        public void Awake()
        {
            _idToHero = new Dictionary<int, HeroView>(_heroes.Length);
            foreach (var hero in _heroes)
            {
                _idToHero.Add(hero.name.GetHashCode(), hero);
            }
        }

        public HeroView GetHeroById(string id)
        {
            if (!_idToHero.TryGetValue(id.GetHashCode(), out var hero))
            {
                throw new ArgumentOutOfRangeException($"Hero with Id {id} does not exist");
            }

            return hero;
        }

    }
}
