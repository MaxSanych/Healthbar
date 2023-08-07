using UnityEngine;
using TMPro;

public class HealthLevelIndicator : MonoBehaviour
{
    [SerializeField] private HealthChanger _healthChanger;
    [SerializeField] private TMP_Text _text;

    private float _value;

    private void Awake()
    {
        _value = _healthChanger.CurrentValue;
        _text.text = _value.ToString();
    }

    private void OnEnable()
    {
        _healthChanger.AmountChanged += ShowValue;
    }

    private void OnDisable()
    {
        _healthChanger.AmountChanged -= ShowValue;

    }

    public void ShowValue()
    {
        _value = _healthChanger.CurrentValue;
        _text.text = _value.ToString();
    }
}
