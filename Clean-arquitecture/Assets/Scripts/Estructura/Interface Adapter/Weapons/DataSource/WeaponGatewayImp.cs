using Assets.Scripts.Estructura.Aplication.Entities;
using Assets.Scripts.Estructura.Interface_Adapter.DataSource;
using Assets.Scripts.Estructura.Interface_Adapter.Weapons.DataSource.Services;

public class WeaponGatewayImp : WeaponGateway
{
    private DataAccess _dataAccess;

    public WeaponGatewayImp(DataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public Weapon GetWeapon(string id)
    {
        var weaponDto = _dataAccess.GetWeapon(id);
        var weapon = new Weapon();

        weapon.Id = weaponDto.Id;
        weapon.Nombre = weaponDto.Nombre;
        weapon.Danyo = weaponDto.Danyo;

        return weapon;
    }
}
