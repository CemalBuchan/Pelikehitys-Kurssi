using UnityEditor.XR;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Ins;
    public bool item;

    private void Start()
    {
        Ins = GetComponent<Inventory>();
    }

    private void Update()
    {
        if(item)
        {
            Debug.Log("Item added");
        }
    }
}
