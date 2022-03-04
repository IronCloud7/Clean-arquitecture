using Assets.Scripts.Estructura._1_Aplication;
using System.Numerics;

public class HeroSpawnUseCase : HeroSpawner
{
    private readonly HeroDataAccess _heroDataAccess;
    private readonly WeaponDataAccess _weaponDataAccess;
    private readonly HeroInstanceAccess _heroInstanceAccess;

    public HeroSpawnUseCase(HeroDataAccess heroDataAccess, WeaponDataAccess weaponDataAccess, HeroInstanceAccess heroInstanceAccess)
    {
        _heroDataAccess = heroDataAccess;
        _weaponDataAccess = weaponDataAccess;
        _heroInstanceAccess = heroInstanceAccess;
    }

    public void Spawn(string id,  Vector3 posicion = default)
    {
        var hero = _heroDataAccess.GetHero(id);
        var weapon = _weaponDataAccess.GetWeapon(hero.Attributes.Weapon);

        _heroInstanceAccess.Add(hero, weapon, posicion);
    }
}
