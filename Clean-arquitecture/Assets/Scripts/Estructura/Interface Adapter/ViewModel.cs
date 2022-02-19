using Assets.Scripts.Utils;
using Code.Utils;
using Patterns.Observer;
using System;
using System.Collections.Generic;


namespace Assets.Scripts
{
    public class ViewModel// : Subject
    {
        private ReactiveCommand _botonPulsado;
        private ReactiveProperty<string> _nombre;
        private ReactiveProperty<float> _danyo;

        private ReactiveProperty<float> _horizontalAxis;
        private ReactiveProperty<float> _verticalAxis;

        public ViewModel()
        {
            _botonPulsado = new ReactiveCommand();

            _horizontalAxis = new ReactiveProperty<float>(default);
            _verticalAxis = new ReactiveProperty<float>(default);

            _nombre = new ReactiveProperty<string>(default);
            _danyo = new ReactiveProperty<float>(default);
        }

        public ReactiveCommand BotonPulsado { get => _botonPulsado; }

        public ReactiveProperty<float> HorizontalAxis { get => _horizontalAxis; set => _horizontalAxis = value; }
        public ReactiveProperty<float> VerticalAxis { get => _verticalAxis; set => _verticalAxis = value; }

        public ReactiveProperty<string> Nombre { get => _nombre; set => _nombre = value; }
        public ReactiveProperty<float> Danyo { get => _danyo; set => _danyo = value; }

    }
}
