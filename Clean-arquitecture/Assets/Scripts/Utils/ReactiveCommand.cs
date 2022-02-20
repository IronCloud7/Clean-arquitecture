using Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
