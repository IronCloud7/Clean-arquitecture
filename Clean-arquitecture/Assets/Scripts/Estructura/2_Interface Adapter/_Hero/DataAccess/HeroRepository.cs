using Assets.Scripts.Estructura._1_Aplication;
using System.Collections.Generic;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroRepository : HeroDataAccess
    {
        private readonly HeroGateway _heroGateway;
        private Dictionary<string, Hero> _heroes;

        public HeroRepository(HeroGateway heroGateway)
        {
            _heroGateway = heroGateway;

            _heroes = new Dictionary<string, Hero>();
        }

        public Hero GetHero(string id)
        {
            Hero hero;

            if (_heroes.TryGetValue(id, out hero))
            {
                return hero;
            } 
            
            var heroDto = _heroGateway.GetHero(id);

            hero = new Hero();
            hero.Id = heroDto.Id;
            hero.Name = heroDto.Name;
            hero.WeaponId = heroDto.WeaponId;

            _heroes.Add(hero.Id, hero);

            return hero;
        }
    }
}
