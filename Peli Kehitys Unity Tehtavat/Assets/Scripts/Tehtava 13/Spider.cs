using UnityEngine;

public class Spider : MonoBehaviour, IDamageable
{
    private int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;

        Debug.Log("Spider health: " + health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}