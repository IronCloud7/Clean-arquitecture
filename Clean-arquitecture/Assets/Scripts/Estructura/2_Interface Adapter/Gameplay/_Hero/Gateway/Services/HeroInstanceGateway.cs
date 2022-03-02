using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public interface HeroInstanceGateway
    {
        Hero GetInstance(HeroConfiguration heroConfiguration);
    }
}


