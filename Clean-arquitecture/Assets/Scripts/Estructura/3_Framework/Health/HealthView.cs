using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    private HealthViewModel _modelView;

    [SerializeField] private Text _health;

    public Text Health { get => _health; set => _health = value; }

    public void Configure(HealthViewModel modelView)
    {
        _modelView = modelView;
        _modelView.MaxHealth.Subscribe(UpdateHealth);
        _modelView.CurrentHealth.Subscribe(UpdateHealth);
    }

    public void UpdateHealth()
    {
        _health.text = $"Vida: {_modelView.CurrentHealth.Value} / {_modelView.MaxHealth.Value}";
    }

    private void OnDestroy()
    {
        _modelView.MaxHealth.Unsubscribe(UpdateHealth);
    }

}
