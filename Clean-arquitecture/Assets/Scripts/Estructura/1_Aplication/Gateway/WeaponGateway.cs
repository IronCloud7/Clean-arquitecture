using Assets.Scripts.Estructura.Aplication.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface WeaponGateway
{
    public Weapon GetWeapon(string id);
}
