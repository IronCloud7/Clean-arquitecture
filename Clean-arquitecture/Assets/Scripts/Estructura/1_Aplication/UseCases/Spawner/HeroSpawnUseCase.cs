using Assets.Scripts.Estructura._1_Aplication;
using System.Numerics;

public class HeroSpawnUseCase : HeroSpawner
{
    private readonly HeroDataAccess _heroDataAccess;
    private readonly HeroInstanceAccess _gameplayHeroDataAccess;

    public HeroSpawnUseCase(HeroDataAccess heroDataAccess, HeroInstanceAccess gameplayHeroDataAccess)
    {
        _heroDataAccess = heroDataAccess;
        _gameplayHeroDataAccess = gameplayHeroDataAccess;
    }

    public void Spawn(string id,  Vector3 posicion = default)
    {
       var hero = _heroDataAccess.GetHero(id);

        _gameplayHeroDataAccess.Add(hero, posicion);
    }
}
