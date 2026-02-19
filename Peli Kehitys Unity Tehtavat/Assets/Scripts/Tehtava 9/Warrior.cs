using UnityEngine;

public class Warrior : Character
{
    public override void Attack()
    {
        Debug.Log($"{Name} Sword!");
    }
}
