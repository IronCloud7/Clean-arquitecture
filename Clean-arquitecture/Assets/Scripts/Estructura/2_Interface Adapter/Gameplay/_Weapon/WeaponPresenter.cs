using Assets.Scripts.Estructura._1_Aplication;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{

    public class WeaponPresenter : UpdaterDamage
    {
        private readonly WeaponViewModel _weaponViewModel;

        public WeaponPresenter(WeaponViewModel weaponViewModel)
        {
            _weaponViewModel = weaponViewModel;
        }

        public void UpdateDamage(WeaponOutputData outputData)
        {

        }
    }
}
