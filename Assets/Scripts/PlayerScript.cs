using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private PlayerActions playerActions;
    private Rigidbody2D rbody;
    private Vector2 moveInput;

    void Awake()
    {
        playerActions = new PlayerActions();

        rbody = GetComponent<Rigidbody2D>();
        if(rbody is null)
            Debug.LogError("Rigidbody2D is null");
    }

    private void OnEnable()
    {
        playerActions.Player_Map.Enable();
    }

    private void OnDisable()
    {
        playerActions.Player_Map.Disable();
    } 

    void FixedUpdate()
    {
        moveInput = playerActions.Player_Map.Movement.ReadValue<Vector2>();
        rbody.velocity = moveInput * speed;
    }

}
