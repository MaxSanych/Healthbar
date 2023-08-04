using UnityEngine;
using TMPro;

public class HealthLevelIndicator : MonoBehaviour
{
    [SerializeField] private HealthChanger _healthChanger;
    [SerializeField] private TMP_Text _text;

    private string _value;

    private void Awake()
    {
        _value = _healthChanger.CurrentValue.ToString();
        _text.text = _value;
    }

    public void ShowValue()
    {
        _value = _healthChanger.CurrentValue.ToString();
        _text.text = _value;
    }
}
