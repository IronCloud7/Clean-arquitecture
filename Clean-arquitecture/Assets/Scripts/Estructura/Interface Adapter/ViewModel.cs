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
        private ReactiveProperty2<string> _nombre;
        private ReactiveProperty2<float> _danyo;

        //private bool _botonPulsado = false;
        //private string _nombre;
        //private float _danyo;

        public ViewModel()
        {
            _botonPulsado = new ReactiveCommand();
            _nombre = new ReactiveProperty2<string>(default);
            _danyo = new ReactiveProperty2<float>(default);
        }

        //private List<Observer> _observers;

        public ReactiveCommand BotonPulsado { get => _botonPulsado; set => _botonPulsado = value; }
        public ReactiveProperty2<string> Nombre { get => _nombre; set => _nombre = value; }
        public ReactiveProperty2<float> Danyo { get => _danyo; set => _danyo = value; }

        //public bool BotonPulsado { get => _botonPulsado; set => _botonPulsado = value; }
        //public string Nombre { get => _nombre; set => _nombre = value; }
        //public float Danyo { get => _danyo; set => _danyo = value; }



        //public ViewModel()
        //{
        //    _observers = new List<Observer>();         
        //}

        //public void Subscribe(Observer observer)
        //{
        //    _observers.Add(observer);
        //}

        //public void Unsubscribe(Observer observer)
        //{
        //    _observers.Remove(observer);
        //}

        //public void Notify()
        //{
        //    foreach (var observer in _observers)
        //    {
        //        observer.Updated(this);
        //    }
        //}
    }
}
