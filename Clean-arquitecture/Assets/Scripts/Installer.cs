using Assets.Scripts.Estructura._1_Aplication.Hero.Gateway;
using Assets.Scripts.Estructura._1_Aplication.UseCases;
using Assets.Scripts.Estructura._1_Aplication.Weapon.Gateway;
using Assets.Scripts.Estructura._2_Interface_Adapter.Hero;
using Assets.Scripts.Estructura._2_Interface_Adapter.Input;
using Assets.Scripts.Estructura._2_Interface_Adapter.Weapon;
using Assets.Scripts.Estructura._2_Interface_Adapter.Weapon.DataSource;
using Assets.Scripts.Estructura._3_Framework;
using Assets.Scripts.Estructura._3_Framework.Hero;
using Assets.Scripts.Estructura._3_Framework.Weapon;
using UnityEngine;
using Input = Assets.Scripts.Estructura._3_Framework.Input;

namespace Assets.Scripts
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private Input _input;
        [SerializeField] private WeaponView _weaponView;
        [SerializeField] private HeroView _heroView;
        [SerializeField] private HeroCollisioner _heroCollisioner;
        [SerializeField] private WeaponDataAccess _weaponDataAccess;

        public void Awake()
        {
            InputModel inputModel = new InputModel();

            //Weapon      
            WeaponViewModel weaponViewModel = new WeaponViewModel();
            WeaponPresenter weaponPresenter = new WeaponPresenter(weaponViewModel);
            WeaponGateway weaponGateway = new WeaponGatewayImp(_weaponDataAccess);

            Attacker attackUseCase = new AttackUseCase(weaponPresenter, weaponGateway);

            //Hero
            HeroViewModel heroViewModel = new HeroViewModel();
            HeroPresenter heroPresenter = new HeroPresenter(heroViewModel);

            HeroColisionerModel heroColisionerModel = new HeroColisionerModel();
            HeroColisionerGateway heroCollisioner = new HeroCollisionerGatewayImp(heroColisionerModel);

            Mover moveUseCase = new MoveUseCase(heroPresenter);
            Jumper jumpUseCase = new JumpUseCase(heroPresenter, heroCollisioner);
            InputController inputController = new InputController(inputModel, attackUseCase, moveUseCase, jumpUseCase);

            //Asignar inputModel al input
            _input.Configure(inputModel);

            //Asignar viewModels a las views
            _weaponView.Configure(weaponViewModel);
            _heroView.Configure(heroViewModel);
            _heroCollisioner.Configure(heroColisionerModel);
        }
    }

}
