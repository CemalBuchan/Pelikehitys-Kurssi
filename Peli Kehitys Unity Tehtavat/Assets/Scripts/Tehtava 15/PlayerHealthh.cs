using System;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Pelaajan terveys ja kuolema. 
/// Tapahtuman k‰ynnist‰j‰
/// </summary>
public class PlayerHealthh : MonoBehaviour
{
    // C# tapahtumat, event est‰‰ ulkopuolisia kutsumasta tapahtumaa
    public static event Action OnPlayerDied;
    public static event Action<int> OnHealthChanged;

    #region HP
    // maksimi el‰m‰, voi vaihtaa editorin kautta
    [SerializeField] private int maxHealth = 100;

    // t‰m‰n hetkinen terveys
    private int currentHealth;

    // Ominaisuus, jonka avulla voi tutkia ja muuttaa nykyist‰ terveytt‰
    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    #endregion

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            TakeDamage(20);
        }

        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            TakeDamage(-10); 
        }
    }


    // Pelaaja ottaa vahinkoa
    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        OnHealthChanged?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("Player died");
            OnPlayerDied?.Invoke();
        }
    }

}
