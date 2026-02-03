using UnityEngine;

public class keyPickup : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerInventory inventory = other.gameObject.GetComponent<PlayerInventory>();
            if (!inventory.hasKey(inventory.currentKeyID))
            {
                inventory.addKey(id);
                gameObject.SetActive(false);
            }
            else
            {
             
                inventory.clearKey();
                inventory.addKey(id);
                gameObject.SetActive(false);
            }
            
        }
    }
}
