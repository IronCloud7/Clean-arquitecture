using Assets.Scripts.Estructura._1_Aplication;
using System.Collections.Generic;
using System.Numerics;

public interface WeaponInstanceAccess
{
    void Add(WeaponData hero, Vector3 posicion);
    Weapon Get(int InstanceId);
    void Remove(int InstanceId);
    IReadOnlyList<Weapon> GetAll();
  
}

