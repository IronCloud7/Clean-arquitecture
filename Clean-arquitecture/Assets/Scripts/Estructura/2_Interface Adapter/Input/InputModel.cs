
using Assets.Scripts.Utils;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Input
{
    public class InputModel
    {
        private readonly ReactiveCommand _botonA;
        private readonly ReactiveCommand _botonB;
        private readonly ReactiveCommand _botonX;
        private readonly ReactiveCommand _botonY;

        private readonly ReactiveProperty<float> _horizontalAxis;
        private readonly ReactiveProperty<float> _verticalAxis;

        public InputModel()
        {
            _botonA = new ReactiveCommand();
            _botonB = new ReactiveCommand();
            _botonX = new ReactiveCommand();
            _botonY = new ReactiveCommand();

            _horizontalAxis = new ReactiveProperty<float>(default);
            _verticalAxis = new ReactiveProperty<float>(default);
        }

        public ReactiveCommand BotonA { get => _botonA; }
        public ReactiveCommand BotonB { get => _botonB; }
        public ReactiveCommand BotonX { get => _botonX; }
        public ReactiveCommand BotonY { get => _botonY; }

        public ReactiveProperty<float> HorizontalAxis { get => _horizontalAxis; }
        public ReactiveProperty<float> VerticalAxis { get => _verticalAxis; }

    }
}
