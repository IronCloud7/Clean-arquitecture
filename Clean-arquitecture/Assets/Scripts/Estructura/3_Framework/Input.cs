using Assets.Scripts.Estructura.Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts
{
    class Input : MonoBehaviour
    {
        private InputModel _modelView;

        public void Configure(InputModel modelView)
        {
            _modelView = modelView;
        }

        void Update()
        {
            _modelView.HorizontalAxis.Value = UnityEngine.Input.GetAxis("Horizontal"); ;
            _modelView.VerticalAxis.Value = UnityEngine.Input.GetAxis("Vertical"); ;


            if (UnityEngine.Input.GetKeyDown(KeyCode.F1))
            {
                _modelView.BotonA.Execute();
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.F2))
            {
                _modelView.BotonB.Execute();
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
            {
                _modelView.BotonX.Execute();
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.F3))
            {
                _modelView.BotonY.Execute();
            }
        }
    }
}
