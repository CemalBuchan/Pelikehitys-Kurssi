using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Character mage;
    [SerializeField] private Character warrior;

    void Update()
    {
        // 🎮 Gamepad X → Mage saldırır
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            mage.Attack();
            warrior.TakeDamage(15);
        }

        // 🖱️ Mouse Left Click → Warrior saldırır
        if (Input.GetMouseButtonDown(0))
        {
            warrior.Attack();
            mage.TakeDamage(20);
        }
    }
}
