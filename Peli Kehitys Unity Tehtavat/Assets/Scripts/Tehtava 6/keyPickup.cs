using UnityEngine;

public class keyPickup : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!PlayerInventory.instance.hasKey(PlayerInventory.instance.currentKeyID))
            {
                PlayerInventory.instance.addKey(id);
                gameObject.SetActive(false);
            }
            else
            {

                PlayerInventory.instance.clearKey();
                PlayerInventory.instance.addKey(id);
                gameObject.SetActive(false);
            }
            
        }
    }
}
