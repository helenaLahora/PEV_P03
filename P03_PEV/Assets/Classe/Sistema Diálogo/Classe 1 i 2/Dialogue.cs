using UnityEngine;

[CreateAssetMenu(fileName = "newDialogue", menuName = "DialogueSystem/Dialogue")]

public class Dialogue : ScriptableObject
{
    public string Name;
    public DialogueNode StartNode;
}
