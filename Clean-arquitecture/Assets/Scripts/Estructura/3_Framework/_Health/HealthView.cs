using Assets.Scripts.Estructura._2_Interface_Adapter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    private HealthViewModel _modelView;

    [SerializeField] private Text _health;
    [SerializeField] private Text _start;
    [SerializeField] private Text _pause;
    //public Text Health { get => _health; set => _health = value; }

    //public void Configure(HealthViewModel modelView)
    //{
    //    _modelView = modelView;
    //    _modelView.MaxHealth.Subscribe(UpdateHealth);
    //    _modelView.CurrentHealth.Subscribe(UpdateHealth);
    //}

    //public void UpdateHealth()
    //{
    //    _health.text = $"Vida: {_modelView.CurrentHealth.Value} / {_modelView.MaxHealth.Value}";
    //}

    //private void OnDestroy()
    //{
    //    _modelView.MaxHealth.Unsubscribe(UpdateHealth);
    //    _modelView.CurrentHealth.Unsubscribe(UpdateHealth);
    //}

    //private void Update()
    //{
    //    switch (GameStateController.Current)
    //    {
    //        case GameStateController.GameState.START:
    //            {
    //                _start.gameObject.SetActive(true); ;
    //                _pause.gameObject.SetActive(false);
    //            }
    //            break;
    //        case GameStateController.GameState.PAUSE:
    //            {
    //                _start.gameObject.SetActive(false);
    //                _pause.gameObject.SetActive(true);
    //            }
    //            break;
    //        case GameStateController.GameState.PLAY:
    //            {
    //                _start.gameObject.SetActive(false);
    //                _pause.gameObject.SetActive(false);
    //            }
    //            break;

    //    }
    //}

}
