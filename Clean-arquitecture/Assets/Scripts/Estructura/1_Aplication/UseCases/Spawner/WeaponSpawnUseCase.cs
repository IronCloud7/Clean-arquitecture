using Assets.Scripts.Estructura._1_Aplication;
using System.Numerics;

public class WeaponSpawnUseCase : WeaponSpawner
{
    private readonly WeaponDataAccess _weaponDataAccess;
    private readonly WeaponInstanceAccess _weaponInstanceAccess;

    public WeaponSpawnUseCase(WeaponDataAccess weaponDataAccess, WeaponInstanceAccess weaponInstanceAccess)
    {
        _weaponDataAccess = weaponDataAccess;
        _weaponInstanceAccess = weaponInstanceAccess;
    }

    public void Spawn(string id,  Vector3 posicion)
    {
       var weapon = _weaponDataAccess.GetWeapon(id);

        _weaponInstanceAccess.Add(weapon, posicion);
    }
}
