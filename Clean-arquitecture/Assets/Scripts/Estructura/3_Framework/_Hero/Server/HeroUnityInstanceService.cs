﻿using Assets.Scripts.Estructura._2_Interface_Adapter;
using UnityEngine;

namespace Assets.Scripts.Estructura._3_Framework
{
    public class HeroUnityInstanceService :  HeroInstanceService
    {
        private readonly HeroFactory _heroFactory;

        public HeroUnityInstanceService(HeroFactory heroFactory)
        {
            _heroFactory = heroFactory;
        }

        public int GetInstance(HeroConfiguration heroConfiguration, HeroViewModel heroViewModel)
        {
            var heroView = _heroFactory.Create(heroConfiguration);

            heroView.Configure(heroViewModel);

            return heroView.GetInstanceID();
        }


    }
}