using System;
using UnityEngine;

public sealed class PlayerHealth
{
    public event Action HealthChanged;

    private readonly PlayerData _data;
    private int _currentHealth;

    public int CurrentHealth { get => _currentHealth; private set => _currentHealth = value; }
    public int MaxHealth => _data.MaxHealth;

    public PlayerHealth(PlayerData data)
    {
        _data = data;
        CurrentHealth = data.MaxHealth;
    }

    public void Increment(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, MaxHealth);
        UpdateHealth();
    }

    public void Decrement(int amount)
    {
        _currentHealth -= amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, MaxHealth);
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        Debug.Log($"Health Changed! Current: {_currentHealth}");
        HealthChanged?.Invoke();
    }
}