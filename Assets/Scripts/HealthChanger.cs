using UnityEngine;
using UnityEngine.Events;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Player _player;

    public event UnityAction AmountChanged;

    private float _minValue = 0f;
    private float _maxValue = 100f;

    public float CurrentValue { get; private set; }

    private void Awake()
    {
        CurrentValue = _player.Health;
    }

    public void ChangeValue(float amountOfDamage)
    {
        CurrentValue += amountOfDamage;

        if (CurrentValue >= _minValue && CurrentValue <= _maxValue)
            AmountChanged?.Invoke();
        else
            CurrentValue -= amountOfDamage;
    }
}
