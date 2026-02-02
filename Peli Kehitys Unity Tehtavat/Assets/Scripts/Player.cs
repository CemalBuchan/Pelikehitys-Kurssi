using UnityEngine;

/// <summary>
/// Player vastaa pelaajan toiminnasta (liikkuminen, hyökkäys).
/// </summary>
public class Player : MonoBehaviour
{
    private Health health;

    void Awake()
    {
        // TODO: hae Health-komponentti
       health = GetComponent<Health>();
        if (health == null)
            Debug.LogError("Health is null");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            TakeDamage(10);
    }


    public void TakeDamage(int amount)
    {        
        // TODO: vähennä elämää Healthin kautta
        health.currentHealth-= amount;
        Debug.Log("Health : " + health.currentHealth);
    }
}

