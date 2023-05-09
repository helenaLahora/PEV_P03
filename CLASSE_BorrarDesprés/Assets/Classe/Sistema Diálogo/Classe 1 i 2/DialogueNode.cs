using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newDialogueNode", menuName = "DialogueSystem/DialogueNode")]

public class DialogueNode : ScriptableObject
{
    public string Speech; 
    public List<DialogueOptions> Options;
}

[System.Serializable] //tota aquesta clase pot apareixer al inspector
public class DialogueOptions
{
    public string Text;
    public DialogueNode NextNode;
}
