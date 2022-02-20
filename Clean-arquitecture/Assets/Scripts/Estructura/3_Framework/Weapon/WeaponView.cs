using Assets.Scripts.Estructura.Interface_Adapter;
using UnityEngine;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    private WeaponViewModel _modelView;

    [SerializeField] private Text _arma;
    [SerializeField] private Text _danyo;

    public void Configure(WeaponViewModel modelView)
    {
        _modelView = modelView;
        _modelView.Nombre.Subscribe(UpdateName);
        _modelView.Danyo.Subscribe(UpdateDamage);
    }

    public void UpdateName()
    {
        _arma.text = $"Arma: {_modelView.Nombre.Value}";
    }

    public void UpdateDamage()
    {
        _danyo.text = $"Daño: {_modelView.Danyo.Value}";
    }

    private void OnDestroy()
    {
        _modelView.Nombre.Unsubscribe(UpdateName);
        _modelView.Danyo.Unsubscribe(UpdateDamage);
    }

}
