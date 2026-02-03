using UnityEngine;

public class Zone : MonoBehaviour
{
    public Gurad guard;
    public string enterTXT = "Player entered the zone";
    public string stayTXT = "Player is in the zone";
    public string exitTXT = "Player exited the zone";


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guard.showMessage(enterTXT);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guard.showMessage(stayTXT);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guard.showMessage(exitTXT);

        }
    }
}
