using System;

namespace Assets.Scripts.Utils
{
    public class ReactiveProperty2<T>
    {
        private T _value;
        private dynamic _actions;

        public T Value
        {
            get { return _value; }
            set { _value = value; Notify(); }
        }

        public ReactiveProperty2(T value)
        {
            _value = value;
        }

        private void Notify()
        {
            if (_actions == null)
                return;

            _actions();
        }

        public void Subscribe(Action action)
        {
            _actions += action;
        }

        public void Unsubscribe(Action action)
        {
            _actions -= action;
        }
    }

 
}
