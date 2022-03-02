using Assets.Scripts.Estructura._2_Interface_Adapter;

namespace Assets.Scripts.Estructura._3_Framework
{
    public interface HeroDataService
    {
        public HeroRaw GetHero(string id);
    }
}
