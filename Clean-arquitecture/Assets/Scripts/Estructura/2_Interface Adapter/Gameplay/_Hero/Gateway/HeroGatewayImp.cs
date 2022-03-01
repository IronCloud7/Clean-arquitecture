using Assets.Scripts.Estructura._3_Framework;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroGatewayImp :  HeroGateway
    {
        private HeroDataService _heroDataService;

        public HeroGatewayImp(HeroDataService heroDataService)
        {
            _heroDataService = heroDataService;
        }

        public HeroDto GetHero(string id)
        {      
            var heroResult = _heroDataService.GetHero(id);

            var heroDto = new HeroDto();
            heroDto.Id = heroResult.Id;
            heroDto.Name = heroResult.Name;
            heroDto.Posicion = heroResult.Posicion;
            heroDto.Weapon  = heroResult.Weapon;
            heroDto.Health = heroResult.Health;
            heroDto.MovementSpeed = heroResult.MovementSpeed;
            heroDto.RunSpeed = heroResult.RunSpeed;
            heroDto.JumpVelocity = heroResult.JumpVelocity;
            heroDto.SecondsBetweenJumps = heroResult.SecondsBetweenJumps;

            return heroDto;
        }
    }
}
