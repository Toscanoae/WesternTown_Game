using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehavior
{
    public DialogueTrigger trigger;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player") == True)
        trigger.StartDialogue();
    }
}