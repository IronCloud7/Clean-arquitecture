using Assets.Scripts.Utils;

namespace Assets.Scripts.Estructura.Interface_Adapter
{
    public class WeaponViewModel
    {
        private ReactiveProperty<string> _nombre;
        private ReactiveProperty<float> _danyo;

        public WeaponViewModel()
        {
            _nombre = new ReactiveProperty<string>(default);
            _danyo = new ReactiveProperty<float>(default);
        }

        public ReactiveProperty<string> Nombre { get => _nombre; set => _nombre = value; }
        public ReactiveProperty<float> Danyo { get => _danyo; set => _danyo = value; }

    }
}
