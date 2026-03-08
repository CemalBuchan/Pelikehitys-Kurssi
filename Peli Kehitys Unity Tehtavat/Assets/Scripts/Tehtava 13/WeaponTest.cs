using UnityEngine;

public class WeaponTest : MonoBehaviour
{
    public Spider spider;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (spider != null)
            {
                spider.TakeDamage(5);
            }
        }
    }
}