using UnityEngine;

public class HealthUI : MonoBehaviour
{
    void OnEnable()
    {
        PlayerHealth.OnHealthChanged += UpdateHealth;
    }

    void OnDisable()
    {
        PlayerHealth.OnHealthChanged -= UpdateHealth;
    }

    void UpdateHealth(int health)
    {
        Debug.Log("Player Health: " + health);
    }
}