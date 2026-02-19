using UnityEngine;

public class Mage : Character
{
    public override void Attack()
    {
        Debug.Log($"{Name} Spell!");
    }
}
