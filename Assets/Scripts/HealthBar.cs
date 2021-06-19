using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text value;

    private float _step = 50f;
    private bool _isSliderValueChanging = false;

    private void Start()
    {
        _slider.maxValue = _player.MaxHealth;
        _slider.value = _player.CurentHealth;
        ShowHealthValueText();
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    public void OnHealthChanged()
    {
        if (_isSliderValueChanging == false)
        {
            StartCoroutine(ChangeSliderValue());
        }
    }

    public void ShowHealthValueText()
    {
        value.text = Convert.ToString(_player.CurentHealth) + "/" + Convert.ToString(_player.MaxHealth);
    }

    private IEnumerator ChangeSliderValue()
    {
        _isSliderValueChanging = true;

        while (_slider.value != _player.CurentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.CurentHealth, _step * Time.deltaTime);
            yield return null;
        }

        _isSliderValueChanging = false;
    }

}