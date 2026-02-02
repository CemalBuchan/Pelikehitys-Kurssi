using UnityEngine;

/// <summary>
/// Avaa arkun
/// </summary>
public class ChestController : MonoBehaviour
{
    [SerializeField] private Animator chestAnimator;

    public bool isOpen = false;

    public void Open()
    {
        isOpen = true;
        chestAnimator.SetBool("isOpen",isOpen);
    }
    public void Close()
    {
        isOpen = false;
        chestAnimator.SetBool("isOpen",isOpen);
    }
}
