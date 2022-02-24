using Assets.Scripts.Utils;

public class MainMenuViewModel
{
    private ReactiveCommand startGameButton;
    public ReactiveCommand StartGameButton { get => startGameButton; set => startGameButton = value; }

    public MainMenuViewModel()
    {
        startGameButton = new ReactiveCommand();
    }


}
