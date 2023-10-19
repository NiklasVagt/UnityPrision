using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int health;
    public LogicHandler logicHandler;

    void Awake()
    {
        logicHandler = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicHandler>();
        health = maxHealth;
    }

    public void DamageTaken(int damage)
    {
        health -= damage;
        if(health <= 0)
        {   
            logicHandler.GameOver();
        }
    }
}
