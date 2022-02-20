using Assets.Scripts.Estructura._1_Aplication.Hero.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Hero
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
           //return _heroColisionerModel.IsGround.Value;
            return _heroColisionerModel.IsGround;
        }
    }
}
