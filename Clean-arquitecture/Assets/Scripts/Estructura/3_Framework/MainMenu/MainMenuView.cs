using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Button StartGameButton;

    private MainMenuViewModel _mainMenuViewModel;

    public void Configure(MainMenuViewModel mainMenuViewModel)
    {
        _mainMenuViewModel = mainMenuViewModel;

        StartGameButton.onClick.AddListener(_mainMenuViewModel.StartGameButton.Execute);
    }
}
