using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 7;
    private Rigidbody2D rbody;
    private PlayerInputHandler playerInput;

    void Awake()
    {
        playerInput = GetComponent<PlayerInputHandler>(); 

        rbody = GetComponent<Rigidbody2D>();
        if(rbody is null)
            Debug.LogError("Rigidbody2D is null");
    }

    void FixedUpdate()
    {
        rbody.velocity = playerInput.moveInput * speed;
    }

}
