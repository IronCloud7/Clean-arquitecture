using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class GroundDataAccessImp : GroundDataAccess
    {
        private readonly GroundModel _groundData;

        public GroundDataAccessImp(GroundModel groundData)
        {
            _groundData = groundData;
        }

        public bool isGround()
        {
            return _groundData.IsGround;
        }
    }
}
