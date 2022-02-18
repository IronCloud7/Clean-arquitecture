using Assets.Scripts.Estructura.Interface_Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{

    class InputPresenter : UpdaterDamage, IDisposable
    {
        private readonly ViewModel _viewModel;
        //private readonly Attacker attackUseCase;

        //public InputPresenter(ViewModel viewModel, Attacker attackUseCase)
        //{
        //    _viewModel = viewModel;

        //    //attackUseCase.OnDamageUpdated += UpdateDamage;
        //    //AttackUseCase.OnDamageEvent += UpdateDamage;
        //    //AttackUseCase.OnDamageAction += UpdateDamage;
        //}

        public InputPresenter(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void UpdateDamage(InputData inputData)
        {
            _viewModel.InputData = inputData;
        }

        public void Dispose()
        {
            //attackUseCase.OnDamageUpdated -= UpdateDamage;
        }
    }
}
