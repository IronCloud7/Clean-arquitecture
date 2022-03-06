using System;

namespace Assets.Scripts.Utils
{
    public class ReactiveProperty<T>
    {
        private T _value;
        private dynamic _actions;

        public ReactiveProperty(T value)
        {
            _value = value;
        }

        public T Value
        {
            get { return _value; }
            set { _value = value; Execute(); }
        }

        private void Execute()
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
