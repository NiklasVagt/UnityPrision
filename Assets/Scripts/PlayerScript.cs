using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private PlayerActions playerActions;
    private Rigidbody2D rbody;
    private Vector2 moveInput;
    public GameObject slash;

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
    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        Vector2 mousePosition;
        Vector2 playerPosition;
        Vector2 attackDirection;
        float angle;

        mousePosition = playerActions.Player_Map.MousePosition.ReadValue<Vector2>();
        playerPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        attackDirection = mousePosition - playerPosition;
        angle = Mathf.Atan2(attackDirection.y, attackDirection.x) * Mathf.Rad2Deg;

        Instantiate(slash, gameObject.transform.position, Quaternion.Euler(0,0,angle));

        Debug.Log(angle);
    }
}
