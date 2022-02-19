using Assets.Scripts.Utils;
using Code.Utils;
using Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class InputController: IDisposable//, Observer
    {
        private ViewModel _viewModel;
        private Attacker _attackUseCase;

        public InputController(ViewModel viewModel, Attacker attackUseCase)
        {
            _viewModel = viewModel;
            _attackUseCase = attackUseCase;

            _viewModel.BotonPulsado.Subscribe<ReactiveCommand.Void>(Updated);
        }

        public void Updated(ReactiveCommand.Void vacio)
        {
            _attackUseCase.Attack(new InputData("0"));
        }
 
        public void Dispose()
        {
            _viewModel.BotonPulsado.Unsubscribe<ReactiveCommand.Void>(Updated);
        }

    
    }
}
