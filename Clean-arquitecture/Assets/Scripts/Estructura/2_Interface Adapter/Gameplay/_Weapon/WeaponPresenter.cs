using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{

    public class WeaponPresenter : UpdaterAttack
    {
        private readonly WeaponViewModel _weaponViewModel;

        public WeaponPresenter(WeaponViewModel weaponViewModel)
        {
            _weaponViewModel = weaponViewModel;
        }

        public void UpdateAttack()
        {
            _weaponViewModel.DoAttack.Value = true;
        }
    }
}
