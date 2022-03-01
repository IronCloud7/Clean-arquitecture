using Assets.Scripts.Estructura._1_Aplication.UseCases;
using System;


public class MainMenuController: IDisposable
{
    private MainMenuViewModel _mainMenuViewModel;
    private StarterGame _starterGame;
    public MainMenuController(MainMenuViewModel mainMenuViewModel, StarterGame starterGame)
    {
        _mainMenuViewModel = mainMenuViewModel;
        _mainMenuViewModel.StartGameButton.Subscribe(StartGame);

        _starterGame = starterGame;
    }

    public void Dispose()
    {
        _mainMenuViewModel.StartGameButton.Unsubscribe(StartGame);
    }

    private void StartGame()
    {
        _starterGame.StartGame();
    }
}
