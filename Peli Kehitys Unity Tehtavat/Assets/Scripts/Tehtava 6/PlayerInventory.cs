using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int currentKeyID;
    public bool key;

    public static PlayerInventory instance;

    private void Start()
    {
        instance = this;
    }
    public bool hasKey(int id)
    {
        id = currentKeyID;
        if (id == 1 || id == 2)
        {
            return true ;
        }
        else
        {
            return false ;
        }
    }

    public void addKey(int id)
    {
        currentKeyID = id;
    }

    public void clearKey()
    {
        currentKeyID = 0;
    }
}
