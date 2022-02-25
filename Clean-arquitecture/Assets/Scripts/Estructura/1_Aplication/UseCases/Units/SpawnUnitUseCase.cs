using Assets.Scripts.Estructura._1_Aplication;

public class SpawnUnitUseCase : UnitSpawner
{
    private readonly HeroDataAccess _heroDataAccess;
    private readonly GameplayHeroDataAccess _gameplayHeroDataAccess;
    public void Spawn(string id)
    {
       var heroUnit = _heroDataAccess.GetHero(id);
        _gameplayHeroDataAccess.Add(heroUnit);
    }
}
