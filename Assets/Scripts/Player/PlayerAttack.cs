using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject slash;
    private PlayerInputHandler playerInput;
    
    void Awake()
    {
        playerInput = GetComponent<PlayerInputHandler>();
        GetComponent<PlayerInputHandler>().OnAttack += Attack;
    }

    public void Attack()
    {
        // Vector2 playerPosition;
        // Vector2 attackDirection;
        // float angle;

        // playerPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        // attackDirection = playerInput.mousePosition - playerPosition;
        // angle = Mathf.Atan2(attackDirection.y, attackDirection.x) * Mathf.Rad2Deg;

        // Instantiate(slash, gameObject.transform.position, Quaternion.Euler(0,0,angle));

        // Debug.Log(angle);


        StartCoroutine(transform.GetChild(0).gameObject.GetComponent<SwordSlash>().Slash(gameObject.transform.position));
        

    }
}
