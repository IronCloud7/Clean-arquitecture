using Assets.Scripts.Estructura.Interface_Adapter;

namespace Assets.Scripts.Estructura.Interface_Adapter
{

    class WeaponPresenter : UpdaterDamage
    {
        private readonly WeaponViewModel _viewModel;

        public WeaponPresenter(WeaponViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void UpdateDamage(WeaponOutputData outputData)
        {
            _viewModel.Nombre.Value = outputData.Nombre;
            _viewModel.Danyo.Value = outputData.Danyo;
        }
    }
}
