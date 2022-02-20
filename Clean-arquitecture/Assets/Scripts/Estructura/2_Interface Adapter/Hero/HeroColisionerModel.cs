using Assets.Scripts.Utils;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Hero
{
    public class HeroColisionerModel
    {
        //private ReactiveProperty<bool> _isGround;
        private bool _isGround;

        public HeroColisionerModel()
        {
        //    _isGround = new ReactiveProperty<bool>(false);
        }

        public bool IsGround { get => _isGround; set => _isGround = value; }

        //public ReactiveProperty<bool> IsGround { get => _isGround; set => _isGround = value; }
    }
}