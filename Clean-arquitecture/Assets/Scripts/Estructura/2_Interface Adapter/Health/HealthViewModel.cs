using Assets.Scripts.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthViewModel
{
    private ReactiveProperty<int> _maxHealth;
    private ReactiveProperty<int> _currentHealth;

    public HealthViewModel()
    {
        _maxHealth = new ReactiveProperty<int>(default);
        _currentHealth = new ReactiveProperty<int>(default);
    }

    public ReactiveProperty<int> MaxHealth { get => _maxHealth; set => _maxHealth = value; }
    public ReactiveProperty<int> CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
}
