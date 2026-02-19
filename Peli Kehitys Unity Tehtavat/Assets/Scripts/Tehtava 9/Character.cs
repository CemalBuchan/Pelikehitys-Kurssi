using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [field: SerializeField] protected string Name { get; set; }
    [field: SerializeField] protected float Health { get; set; }

    protected virtual void Start()
    {
        Debug.Log($"{Name} spawn . HP: {Health}");
    }

    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
        Debug.Log($"{Name} sai {damageAmount} vahinkoa! HP: {Health}");

        if (Health <= 0)
        {
            Debug.Log($"{Name} hävisi taistelu!");
        }
    }
}








