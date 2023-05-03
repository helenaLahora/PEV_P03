using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNode : ScriptableObject
{
    public string Speech; 
    public List<DialogueOptions> Options;

    public class DialogueOptions
    {
        public string Text;
        public DialogueNode NextNode;
    }
}
