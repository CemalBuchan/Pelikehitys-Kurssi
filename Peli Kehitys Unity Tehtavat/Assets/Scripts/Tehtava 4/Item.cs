using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Inventory.Ins.item = true;
            Destroy(gameObject);
        }
    }

   
}
