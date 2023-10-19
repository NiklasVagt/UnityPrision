using System;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public PlayerActions playerActions;
    public Vector2 moveInput;
    public Vector2 mousePosition;
    private bool attackPressed;

    public event Action OnAttack = delegate { };
    void Awake()
    {
        playerActions = new PlayerActions();
    }

    private void OnEnable()
    {
        playerActions.Player_Map.Enable();
    }

    private void OnDisable()
    {
        playerActions.Player_Map.Disable();
    } 

    void Update()
    {
        moveInput = playerActions.Player_Map.Movement.ReadValue<Vector2>();
        mousePosition = playerActions.Player_Map.MousePosition.ReadValue<Vector2>();
        if(playerActions.Player_Map.Attack.WasPressedThisFrame())
            OnAttack();
    }
}
