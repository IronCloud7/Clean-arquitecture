using Assets.Scripts.Estructura._1_Aplication.Weapon.Models;
using Assets.Scripts.Estructura._1_Aplication.Weapon.Service;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Weapon
{

    public class WeaponPresenter : UpdaterDamage
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
