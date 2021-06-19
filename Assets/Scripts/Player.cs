using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField ]private int _maxHealth;
    [SerializeField ]private int _variableValue;

    private float _curentHealth;

    public int MaxHealth => _maxHealth;
    public float CurentHealth => _curentHealth;

    public event UnityAction HealthChanged;

    private void Start()
    {
        _curentHealth = _maxHealth;
        HealthChanged?.Invoke();
    }

    public void TakeDamage()
    {
        if (_curentHealth - _variableValue >= 0)
        {
            _curentHealth -= _variableValue;
           HealthChanged?.Invoke();
        }
    }

    public void Healing()
    {
        if (_curentHealth + _variableValue <= _maxHealth)
        {
            _curentHealth += _variableValue;
            HealthChanged?.Invoke();
        }
    }
}
