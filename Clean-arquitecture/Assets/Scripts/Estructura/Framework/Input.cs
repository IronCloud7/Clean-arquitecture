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
            var horizontalAxis = UnityEngine.Input.GetAxis("Horizontal");
            var verticalAxis = UnityEngine.Input.GetAxis("Vertical");

            if (!horizontalAxis.Equals(_modelView.HorizontalAxis.Value))
                _modelView.HorizontalAxis.Value = horizontalAxis;

            if (!verticalAxis.Equals(_modelView.VerticalAxis.Value))
                _modelView.VerticalAxis.Value = verticalAxis;

            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                _modelView.BotonPulsado.Execute();

                //_modelView.BotonPulsado = true;
                //_modelView.Notify();
            }

        }

       


    }
}
