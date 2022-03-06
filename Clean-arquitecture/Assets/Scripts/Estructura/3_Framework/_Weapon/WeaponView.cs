using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Estructura._3_Framework
{
    public abstract class WeaponView : MonoBehaviour
    {
        [SerializeField] public LayerMask _whatIsEnemy;
        [SerializeField] public ParticleSystem _impact;

        protected WeaponViewModel _weaponViewModel;

        public void Configure(WeaponViewModel weaponViewModel)
        {
            _weaponViewModel = weaponViewModel;
            _weaponViewModel.DoAttack.Subscribe(UpdateAttack);
        }

        protected abstract void UpdateAttack();

        private void OnDestroy()
        {
            _weaponViewModel.DoAttack.Unsubscribe(UpdateAttack);
        }
    }
}
