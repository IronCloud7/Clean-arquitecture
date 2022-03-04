using Assets.Scripts.Estructura._1_Aplication;
using System.Numerics;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class HeroConfiguration
    {
        private readonly Vector3 _position;
        private readonly HeroData _heroData;

        public HeroConfiguration(HeroData hero, Vector3 position)
        {
            _heroData = hero;
            _position = position;
        }

        public string Id => _heroData.Id;
        public HeroData HeroData => _heroData;
        public Vector3 Position => _position;

    }
}
