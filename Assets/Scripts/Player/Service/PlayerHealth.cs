using System;
using UnityEngine;

public sealed class PlayerHealth
{
    public event Action HealthChanged;

    private readonly PlayerData _data;
    private int currentHealth;

    public int CurrentHealth { get => currentHealth; private set => currentHealth = value; }
    public int MaxHealth => _data.MaxHealth;

    public PlayerHealth(PlayerData data)
    {
        _data = data;
        CurrentHealth = data.MaxHealth;
    }

    public void Increment(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, MaxHealth);
        UpdateHealth();
    }

    public void Decrement(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, MaxHealth);
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        HealthChanged.Invoke();
    }
}
