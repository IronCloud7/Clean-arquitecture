using Assets.Scripts.Estructura._1_Aplication;
using Assets.Scripts.Estructura._1_Aplication.UseCases;
using Assets.Scripts.Estructura._2_Interface_Adapter;
using Assets.Scripts.Estructura._3_Framework;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts
{
    public class MenuInstaller : MonoBehaviour
    {
        [SerializeField] private MainMenuView _mainMenuView;

        public void Awake()
        {
            InitializeMenu();
        }

        public void InitializeMenu()
        {
            StarterGame starterGame = new StartGameUseCase();

            MainMenuViewModel mainMenuViewModel = new MainMenuViewModel();
            MainMenuController mainMenuController = new MainMenuController(mainMenuViewModel, starterGame);

            _mainMenuView.Configure(mainMenuViewModel);
        }
    }

}
