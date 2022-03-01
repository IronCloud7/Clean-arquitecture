using Assets.Scripts.Estructura._1_Aplication;
using System.Collections.Generic;
using System.Numerics;

public interface GameplayHeroDataAccess
{
    void Add(Hero hero, Vector3 posicion);
    GameplayHero Get(int InstanceId);
    void Remove(int InstanceId);
    IReadOnlyList<GameplayHero> GetAll();
  
}

