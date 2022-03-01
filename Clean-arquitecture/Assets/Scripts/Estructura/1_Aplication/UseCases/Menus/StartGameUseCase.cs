using UnityEngine.SceneManagement;

namespace Assets.Scripts.Estructura._1_Aplication.UseCases
{
    public class StartGameUseCase : StarterGame
    {
        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}
