using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Custom/Weapon Data")]
public class WeaponData : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private string nombre;
    [SerializeField] private float danyo;

    public string Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Danyo { get => danyo; set => danyo = value; }
}
