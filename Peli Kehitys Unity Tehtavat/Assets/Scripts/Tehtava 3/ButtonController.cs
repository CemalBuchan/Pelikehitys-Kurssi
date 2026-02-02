using UnityEngine;

/// <summary>
/// Luokka on vuorovaikutuksessa painikkeen kanssa.
/// </summary>
public class ButtonController : MonoBehaviour
{
    // Referenssi avattavaan arkkuun
    [SerializeField] private ChestController chest;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            if(chest.isOpen)
            {
                chest.Close();

            }
            else
                chest.Open();
        }
    }

}
