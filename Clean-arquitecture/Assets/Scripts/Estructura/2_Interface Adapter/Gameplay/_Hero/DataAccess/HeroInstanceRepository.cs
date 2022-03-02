using Assets.Scripts.Estructura._1_Aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroInstanceRepository : HeroInstanceAccess
    {
        private readonly HeroInstanceGateway _heroInstanceGateway;
        private readonly Dictionary<int, Hero> _heroes;

        public HeroInstanceRepository(HeroInstanceGateway heroInstanceGateway)
        {
            _heroInstanceGateway = heroInstanceGateway;
            _heroes = new Dictionary<int, Hero>();
        }

        public void Add(HeroData heroData, Vector3 posicion = default)
        {       
            var spawnPosition = posicion != default ? posicion : heroData.Posicion;
            var heroConfiguration = new HeroConfiguration(heroData, spawnPosition);
       
            var hero = _heroInstanceGateway.GetInstance(heroConfiguration);

            _heroes.Add(hero.InstanceId, hero);
        }

        public Hero Get(int InstanceId)
        {
            Hero hero;

            if (!_heroes.TryGetValue(InstanceId, out hero))
            {
                throw new ArgumentOutOfRangeException($"Hero with Id {InstanceId} does not exist");
            }

            return hero;
        }

        public void Remove(int InstanceId)
        {

            if (!_heroes.Remove(InstanceId))
            {
                throw new ArgumentOutOfRangeException($"Hero with Id {InstanceId} does not exist");
            }
        }

        public IReadOnlyList<Hero> GetAll()
        {         
            return _heroes.Values.ToList<Hero>();
        }
    }
}
