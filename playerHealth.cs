using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehavior
{
    public float health;
    public float maxHealth;
    public Image heathBar;

    void Start()
    {
        maxHealth = health;
    }

    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if(health <= 0)
        {
            Destroy(gameObject); //Replace with deathscreen or animation for player death or restart.
        }
    }
}