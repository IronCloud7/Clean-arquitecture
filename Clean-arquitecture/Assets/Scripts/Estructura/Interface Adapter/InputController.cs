using Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class InputController: IDisposable, Observer
    {
        private ViewModel _viewModel;
        private Attacker _attackUseCase;

        public InputController(ViewModel viewModel, Attacker attackUseCase)
        {
            _viewModel = viewModel;
            _attackUseCase = attackUseCase;

            _viewModel.Subscribe(this);
        }

        public void Updated(Subject subject)
        {
            if (subject is ViewModel viewModel)
            {
                if (viewModel.BotonPulsado)
                {
                    _attackUseCase.Attack(new InputData("Espada", UnityEngine.Random.Range(5,10)));
                  
                    viewModel.BotonPulsado = false;
                }
            }
        }

        public void Dispose()
        {
            _viewModel.Unsubscribe(this);
        }
    }
}
