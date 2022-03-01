using Assets.Scripts.Estructura._1_Aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class GameplayHeroRepository : GameplayHeroDataAccess
    {
        private readonly GameplayHeroGateway _gameplayHeroGateway;
        private readonly Dictionary<int, GameplayHero> _gameplayHeroes;

        public GameplayHeroRepository(GameplayHeroGateway gameplayHeroGateway)
        {
            _gameplayHeroGateway = gameplayHeroGateway;
            _gameplayHeroes = new Dictionary<int, GameplayHero>();
        }

        public void Add(Hero hero, Vector3 posicion = default)
        {       
            var spawnPosition = posicion != default ? posicion : hero.Posicion;
            var heroConfiguration = new HeroConfiguration(hero, spawnPosition);
       
            var gamePlayHero = _gameplayHeroGateway.GetInstance(heroConfiguration);

            _gameplayHeroes.Add(gamePlayHero.InstanceId, gamePlayHero);
        }

        public GameplayHero Get(int InstanceId)
        {
            GameplayHero gameplayHero;

            if (!_gameplayHeroes.TryGetValue(InstanceId, out gameplayHero))
            {
                throw new ArgumentOutOfRangeException($"GameplayHero with Id {InstanceId} does not exist");
            }

            return gameplayHero;
        }

        public void Remove(int InstanceId)
        {

            if (!_gameplayHeroes.Remove(InstanceId))
            {
                throw new ArgumentOutOfRangeException($"GameplayHero with Id {InstanceId} does not exist");
            }
        }

        public IReadOnlyList<GameplayHero> GetAll()
        {         
            return _gameplayHeroes.Values.ToList<GameplayHero>();
        }
    }
}
