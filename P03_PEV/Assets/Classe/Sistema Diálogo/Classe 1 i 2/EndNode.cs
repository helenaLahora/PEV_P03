using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEndNode", menuName = "DialogueSystem/EndNode")]

public class EndNode : DialogueNode
{
    public void EndAction(GameObject talker)
    {
        talker.GetComponent<Renderer>().material.color = Color.red;
        Debug.Log("This is the end, my only friend, the end");
    }
}
