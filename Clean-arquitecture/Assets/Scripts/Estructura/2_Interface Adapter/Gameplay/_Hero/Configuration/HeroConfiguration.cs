using Assets.Scripts.Estructura._1_Aplication;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroConfiguration
    {
        private readonly Vector3 _position;
        private readonly Hero _hero;

        public HeroConfiguration(Hero hero, Vector3 position)
        {
            _hero = hero;
            _position = position;
        }

        public string Id => _hero.Id;
        public Hero Hero => _hero;
        public Vector3 Position => _position;

    }
}
