using Assets.Scripts.Estructura._3_Framework;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroDataGatewayImp :  HeroDataGateway
    {
        private HeroDataService _heroDataService;

        public HeroDataGatewayImp(HeroDataService heroDataService)
        {
            _heroDataService = heroDataService;
        }

        public HeroDto GetHero(string id)
        {      
            var heroRaw = _heroDataService.GetHero(id);

            var heroDto = new HeroDto();
            heroDto.Id = heroRaw.Id;
            heroDto.Name = heroRaw.Name;
            heroDto.Posicion = heroRaw.Posicion;
            heroDto.Weapon  = heroRaw.Weapon;
            heroDto.Health = heroRaw.Health;
            heroDto.MovementSpeed = heroRaw.MovementSpeed;
            heroDto.RunSpeed = heroRaw.RunSpeed;
            heroDto.JumpVelocity = heroRaw.JumpVelocity;
            heroDto.SecondsBetweenJumps = heroRaw.SecondsBetweenJumps;

            return heroDto;
        }
    }
}
