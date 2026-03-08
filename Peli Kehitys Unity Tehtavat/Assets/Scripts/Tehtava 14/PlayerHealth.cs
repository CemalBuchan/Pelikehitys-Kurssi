using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    public static Action<int> OnHealthChanged;
    public static Action OnPlayerDied;

    void Start()
    {
        OnHealthChanged?.Invoke(health);
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;

        OnHealthChanged?.Invoke(health);

        if (health <= 0)
        {
            OnPlayerDied?.Invoke();
        }
    }
}