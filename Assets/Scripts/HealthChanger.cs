using UnityEngine;

public class HealthChanger : MonoBehaviour
{

    [SerializeField] private HitButton _hitButton;
    [SerializeField] private CureButton _cureButton;

    private float _minValue = 0f;
    private float _maxValue = 100f;

    public float CurrentValue { get; private set; }

    public void DecreaseValue()
    {
        if (CurrentValue > _minValue)
            CurrentValue -= _hitButton.AmountOfDamage;
    }

    public void IncreaseValue()
    {
        if (CurrentValue < _maxValue)
            CurrentValue += _cureButton.AmountOfHealthCured;
    }
}
