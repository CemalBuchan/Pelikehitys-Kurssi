using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    // Viittaus CharacterController-komponenttiin
    private CharacterController characterController;
    // Painovoima
    private float gravity = -9.81f;
    // Y-akselin suuntainen nopeus
    private float verticalVelocity;
    private void Awake()
    {
        // Hae CharacterController-komponentti
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        // Lue liikesyöte
        Vector2 moveInput = ReadMovementInput();
        // Käsittele hyökkäys
        HandleAttack();
        // Käsittele hyppy
        HandleJump();
        // Siirrä pelaajaa syötteen perusteella
        Move(moveInput);
    }
    private void Move(Vector2 moveInput)
    {
        // Onko pelaaja maassa JA silti vielä putoamassa?
        if (characterController.isGrounded && verticalVelocity < 0f)
        {
            // hahmo pysyy varmasti maassa, ei "leiju" tai tärise
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;
        // Laske pelaajan liikesuunta
        Vector3 direction = transform.right * moveInput.x +
        transform.forward * moveInput.y;
        // Laske pelaajan liikenopeus
        Vector3 velocity = direction * moveSpeed + Vector3.up *
        verticalVelocity;
        // Siirrä pelihahmoa CharacterControllorein avulla
        characterController.Move(velocity * Time.deltaTime);
    }
    Vector2 ReadMovementInput()
    {
        // Alusta liikesyöte nollaksi
        Vector2 moveInput = Vector2.zero;
        // GAMEPAD: Tarkista onko peliohjain kytkettynä
        if (Gamepad.current != null)
        {
            moveInput = Gamepad.current.leftStick.ReadValue();
        }

        if (Keyboard.current != null)
        {
            float x = 0f;
            float y = 0f;
            // Esim. A = vasen, D = oikea, W = eteen, S = taakse
            if (Keyboard.current.aKey.isPressed) x -= 1f;
            if (Keyboard.current.dKey.isPressed) x += 1f;
            if (Keyboard.current.wKey.isPressed) y += 1f;
            if (Keyboard.current.sKey.isPressed) y -= 1f;
            // Tarkistaa Liikkuuko pelaaja yhtään mihinkään suuntaan?
            if (x != 0f || y != 0f)
            {
                // Jos liikkuu niin ota syöte vastaan
                moveInput = new Vector2(x, y).normalized;
            }
        }

        return moveInput;
    }
    void HandleAttack()
    {
        // Tarkistaa että Gamepad on kytketty
        if (Gamepad.current == null)
            return;
        if (Gamepad.current.rightTrigger.wasPressedThisFrame)
        {
            Debug.Log("Hyökkäys aktivoitu");
        }
    }
    void HandleJump()
    {
        if (Gamepad.current == null) return;
        if (Gamepad.current.buttonSouth.wasPressedThisFrame &&
        characterController.isGrounded)
        {
            verticalVelocity = 5f; // Isompi luku --> korkeempi hyppy
        }
    }
}

