using UnityEngine;

public class Switch : MonoBehaviour
{
    public LightController LightController;
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            LightController.turnOn();
        }
        else if (Input.GetMouseButtonDown(0)) 
        {
            LightController.turnOff();
        }

    }
}
