using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;

public class GameplayHeroRepository : GameplayHeroDataAccess
{
    private readonly HeroInstantiatorGateway _heroInstantiatorGateway;
    
    public void Add(Hero heroUnit)
    {
        _heroInstantiatorGateway.Instantiate(new HeroConfiguration(heroUnit.Id));
    }
}