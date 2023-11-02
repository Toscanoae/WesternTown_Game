using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehavior
{
    public playerHealth pHealth;
    public float damage;
    void Start()
    {

    }

    void update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetCompenent<playerHealth>().health -= damage;
        }
    }
}