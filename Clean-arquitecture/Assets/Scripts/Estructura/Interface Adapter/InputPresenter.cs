using Assets.Scripts.Estructura.Interface_Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{

    class InputPresenter : UpdaterDamage
    {
        private readonly ViewModel _viewModel;

        public InputPresenter(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void UpdateDamage(OutputData outputData)
        {
            _viewModel.Nombre.Value = outputData.Nombre;
            _viewModel.Danyo.Value = outputData.Danyo;
        }
    }
}
