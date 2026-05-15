using UnityEngine;
using System;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] private float hp = 100f;
    [SerializeField] private int vidas = 9;

    public Action<float> OnHpChanged;
    public Action<int> OnVidasChanged;

    public float HP
    {
        get => hp;
        set
        {
            hp = Mathf.Clamp(value, 0, 100);
            OnHpChanged?.Invoke(hp);
        }
    }

    public int Vidas
    {
        get => vidas;
        set
        {
            vidas = Mathf.Max(0, value);
            OnVidasChanged?.Invoke(vidas);
        }
    }

    private void OnValidate()
    {
        OnHpChanged?.Invoke(hp);
        OnVidasChanged?.Invoke(vidas);
    }
}