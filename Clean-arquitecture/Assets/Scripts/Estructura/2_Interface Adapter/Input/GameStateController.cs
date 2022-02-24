using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Estructura._2_Interface_Adapter
{
    public class GameStateController : IDisposable
    {
        private InputModel _inputModel;
        public enum GameState { START, PLAY, PAUSE, RESTART, QUIT}
        public static GameState Current;

        public GameStateController(InputModel inputModel)
        {
            _inputModel = inputModel;

            _inputModel.StartButtonPressed.Subscribe(StartGame);
            _inputModel.PauseButtonPressed.Subscribe(PauseGame);
            _inputModel.QuitButtonPressed.Subscribe(quitGame);
            _inputModel.RestartButtonPressed.Subscribe(restartGame);

            Current = GameState.START;
            Time.timeScale = 0;
        }

        public void StartGame()
        {
            if(Current == GameState.START)
            {
                Current = GameState.PLAY;
                Time.timeScale = 1;
            }
        }

        public void PauseGame()
        {
            if(Current == GameState.PLAY)
            {
                Current = GameState.PAUSE;
                Time.timeScale = 0;
                return;
            } 

            if(Current == GameState.PAUSE) 
            {    
                Current = GameState.PLAY;
                Time.timeScale = 1;
                return;
            }          
        }

        public void quitGame()
        {
            Application.Quit();
        }

        public void restartGame()
        {
            if (Current != GameState.START)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        public void Dispose()
        {
            _inputModel.StartButtonPressed.Unsubscribe(StartGame);
            _inputModel.PauseButtonPressed.Unsubscribe(PauseGame);
            _inputModel.QuitButtonPressed.Unsubscribe(quitGame);
            _inputModel.RestartButtonPressed.Unsubscribe(restartGame);
        }


    }
}
