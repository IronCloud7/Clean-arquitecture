using Assets.Scripts.Estructura._1_Aplication;
using System.Collections.Generic;
using System.Numerics;

public interface HeroInstanceAccess
{
    void Add(HeroData hero, Vector3 posicion);
    Hero Get(int InstanceId);
    void Remove(int InstanceId);
    IReadOnlyList<Hero> GetAll();
  
}

