using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroCollisionerGatewayImp : HeroColisionerGateway
    {
        private readonly HeroColisionerModel _heroColisionerModel;

        public HeroCollisionerGatewayImp(HeroColisionerModel heroColisionerModel)
        {
            _heroColisionerModel = heroColisionerModel;
        }

        public bool isGround()
        {
            return _heroColisionerModel.IsGround;
        }
    }
}
