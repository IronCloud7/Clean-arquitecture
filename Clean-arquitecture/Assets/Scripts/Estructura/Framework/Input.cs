using Assets.Scripts.Utils;
using Code.Utils;
using System;
using UnityEngine;

namespace Assets.Scripts
{
    class Input : MonoBehaviour
    {
        private ViewModel _modelView;

        public void Configure(ViewModel modelView)
        {
            _modelView = modelView;
        }

        void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                _modelView.BotonPulsado.Notify(new ReactiveCommand.Void());
    
                //_modelView.BotonPulsado = true;
                //_modelView.Notify();
            }
        }
    }
}
