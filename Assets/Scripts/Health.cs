using System;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    public TMP_Text value;

    public int VariableValue { get; } = 10;
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; private set; } = 100;

    private void Start()
    {
        CurrentHealth = MaxHealth;
        ShowHealthValue();
    }

    public void ShowHealthValue()
    {
        value.text = Convert.ToString(CurrentHealth) + "/" + Convert.ToString(MaxHealth);
    }
}
