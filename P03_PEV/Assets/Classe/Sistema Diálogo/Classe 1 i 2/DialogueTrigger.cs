using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue Dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")//còmprovem que el que hagi entrat es el player (no fer servir a casa)
        {
            //DialogueManager.Instance.Show();//un cop preparat puc dir que es mostri
            DialogueManager.Instance.StartDialogue(Dialogue, gameObject);
        }
    }
}
