using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public int requiredKeyID;

    public bool isOpen;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void open()
    {
        isOpen = true;
        animator.SetBool("isOpen", isOpen);
    }

    void tryOpen(PlayerInventory inventory)
    {
        if (inventory.currentKeyID == requiredKeyID)
        {
            open();
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInventory inventory = other.gameObject.GetComponent<PlayerInventory>();
            if (Input.GetKeyDown(KeyCode.E))
            {
                tryOpen(inventory);
            }
        }
    }
}
