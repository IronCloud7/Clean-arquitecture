using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class GroundGatewayImp : GroundGateway
    {
        private readonly GroundModel _groundData;

        public GroundGatewayImp(GroundModel groundData)
        {
            _groundData = groundData;
        }

        public bool isGround()
        {
            return _groundData.IsGround;
        }
    }
}
