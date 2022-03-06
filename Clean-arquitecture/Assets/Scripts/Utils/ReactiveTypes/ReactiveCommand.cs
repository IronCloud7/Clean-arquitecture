using System;

namespace Assets.Scripts.Utils
{
    public class ReactiveCommand
    {
        private dynamic _actions;

        public void Execute()
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
