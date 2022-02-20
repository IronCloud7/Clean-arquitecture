
using Assets.Scripts.Utils;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Hero
{
    public class HeroViewModel
    {
        private ReactiveProperty<float> _horizontalAxis;
        private ReactiveProperty<float> _verticalAxis;

        private ReactiveCommand _jump;

        public HeroViewModel()
        {
            _horizontalAxis = new ReactiveProperty<float>(default);
            _verticalAxis = new ReactiveProperty<float>(default);

            _jump = new ReactiveCommand();
        }

        public ReactiveProperty<float> HorizontalAxis { get => _horizontalAxis; set => _horizontalAxis = value; }
        public ReactiveProperty<float> VerticalAxis { get => _verticalAxis; set => _verticalAxis = value; }

        public ReactiveCommand Jump { get => _jump; }
    }
}
