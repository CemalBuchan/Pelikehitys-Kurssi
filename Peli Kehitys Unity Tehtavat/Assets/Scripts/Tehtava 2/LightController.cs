using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light light;

    private void Start()
    {
        light = GetComponent<Light>();
        light.enabled = false;
    }

    public void turnOn()
    {
        light.enabled = true;
    }
    public void turnOff()
    {
        light.enabled = false;
    }
}
