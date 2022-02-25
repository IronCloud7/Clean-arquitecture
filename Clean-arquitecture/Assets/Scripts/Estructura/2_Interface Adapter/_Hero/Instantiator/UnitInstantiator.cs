namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class UnitInstantiator : HeroInstantiatorGateway
    {
        //private readonly HeroFactory _heroFactory;
        public void Instantiate(HeroConfiguration heroConfiguration)
        {
           // var heroView = _heroFactory.Create(heroConfiguration);
        }
    }


}
