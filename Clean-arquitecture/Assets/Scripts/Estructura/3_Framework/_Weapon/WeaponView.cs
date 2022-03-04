using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Estructura._3_Framework
{
    public abstract class WeaponView : MonoBehaviour
    {
        protected WeaponViewModel _modelView;

        public void Configure(WeaponViewModel modelView)
        {
            _modelView = modelView;
        }
    }
}
