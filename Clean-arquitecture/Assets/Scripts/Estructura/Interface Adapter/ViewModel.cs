using Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class ViewModel : Subject
    {
        private bool _botonPulsado = false;
        private InputData _inputData;

        private List<Observer> _observers;

        public bool BotonPulsado { get => _botonPulsado; set => _botonPulsado = value; }
        public InputData InputData { get => _inputData; set => _inputData = value; }

        public ViewModel()
        {
            _inputData = new InputData("", 0);
            _observers = new List<Observer>();
        }

        public void UpdateInputData(InputData inputData)
        {
            _inputData = inputData;
        }

        public void Subscribe(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Updated(this);
            }
        }
    }
}
