using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Slider))]

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private HealthChanger _healthChanger;

    private int _changeValueTime = 1;

    private float _currentValue;

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        SetPosition();
    }

    private void OnEnable()
    {
        _healthChanger.AmountChanged += ChangePosition;
    }

    private void OnDisable()
    {
        _healthChanger.AmountChanged -= ChangePosition;
    }

    public void ChangePosition()
    {
        SetPosition();
    }

    private void SetPosition()
    {
        _currentValue = _healthChanger.CurrentValue;
        _slider.DOValue(_currentValue, _changeValueTime).SetEase(Ease.Linear).SetAutoKill(false);
    }
}
