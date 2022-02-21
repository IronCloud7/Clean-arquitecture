﻿using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private Input _input;

        [SerializeField] private HeroView _heroView;
        [SerializeField] private GroundCollisionDetector _groundCollisionDetector;

        [SerializeField] private WeaponView _weaponView;
        [SerializeField] private WeaponUnityDataService _weaponService;

        public void Awake()
        {
            InputModel inputModel = new InputModel();

            //Weapon      
            WeaponViewModel weaponViewModel = new WeaponViewModel();
            WeaponPresenter weaponPresenter = new WeaponPresenter(weaponViewModel);   
            
            WeaponGateway weaponGateway = new WeaponGatewayImp(_weaponService);
            WeaponDataAccess weaponRepository = new WeaponRepository(weaponGateway);

            Attacker attackUseCase = new AttackUseCase(weaponPresenter, weaponRepository);

            //Hero
            HeroViewModel heroViewModel = new HeroViewModel();
            HeroPresenter heroPresenter = new HeroPresenter(heroViewModel);

            GroundModel groundModel = new GroundModel();
            GroundDataAccess groundDataAccess = new GroundDataAccessImp(groundModel);

            Mover moveUseCase = new MoveUseCase(heroPresenter);
            Jumper jumpUseCase = new JumpUseCase(heroPresenter, groundDataAccess);
            InputController inputController = new InputController(inputModel, attackUseCase, moveUseCase, jumpUseCase);

            //Asignar inputModel al input
            _input.Configure(inputModel);

            //Asignar viewModels a las views
            _weaponView.Configure(weaponViewModel);
            _heroView.Configure(heroViewModel);
            _groundCollisionDetector.Configure(groundModel);
        }
    }

}
