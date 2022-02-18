using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    private ViewModel _modelView;

    [SerializeField] private Text _arma;
    [SerializeField] private Text _damage;

    public void Configure(ViewModel modelView)
    {
        _modelView = modelView;
    }

    public void Update()
    {
        _arma.text = $"arma: {_modelView.InputData.Arma}";
        _damage.text = $"damage: {_modelView.InputData.Damage.ToString()}";
    }
}
