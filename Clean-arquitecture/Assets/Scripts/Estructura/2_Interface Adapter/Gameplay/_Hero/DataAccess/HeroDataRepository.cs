using Assets.Scripts.Estructura._1_Aplication;
using System.Collections.Generic;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroDataRepository : HeroDataAccess
    {
        private readonly HeroDataGateway _heroDataGateway;
        private Dictionary<string, HeroData> _heroesData;

        public HeroDataRepository(HeroDataGateway heroDataGateway)
        {
            _heroDataGateway = heroDataGateway;
            _heroesData = new Dictionary<string, HeroData>();
        }

        public HeroData GetHero(string id)
        {
            HeroData heroData;

            if (_heroesData.TryGetValue(id, out heroData))
            {
                return heroData;
            } 
            
            var heroDto = _heroDataGateway.GetHero(id);

            heroData = new HeroData();
            heroData.Id = heroDto.Id;
            heroData.Name = heroDto.Name;
            heroData.Posicion = heroDto.Posicion;
            heroData.Attributes.Weapon = heroDto.Weapon;
            heroData.Attributes.Health = heroDto.Health;
            heroData.Attributes.MovementSpeed = heroDto.MovementSpeed;
            heroData.Attributes.JumpVelocity = heroDto.JumpVelocity;
            heroData.Attributes.RunSpeed = heroDto.RunSpeed;
            heroData.Attributes.SecondsBetweenJumps = heroDto.SecondsBetweenJumps;

            _heroesData.Add(heroData.Id, heroData);

            return heroData;
        }
    }
}
