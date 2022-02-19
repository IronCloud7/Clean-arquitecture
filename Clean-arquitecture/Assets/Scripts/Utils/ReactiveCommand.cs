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
        public  class Void{}

        private readonly Dictionary<Type, dynamic> _actions;

        public ReactiveCommand()
        {
            _actions = new Dictionary<Type, dynamic>();
        }

        public void Notify<T>(T signal)
        {
            var type = typeof(T);
            if (!_actions.ContainsKey(type))
                return;
            _actions[type](signal);
        }

        public void Subscribe<T>(Action<T> action)
        {
            var type = typeof(T);
            if (!_actions.ContainsKey(type))
            {
                _actions.Add(type, null);
            }

            _actions[type] += action;
        }

        public void Unsubscribe<T>(Action<T> action)
        {
            var type = typeof(T);
            if (_actions.ContainsKey(type))
            {
                _actions[type] -= action;
            }
        }
    }

 
}
