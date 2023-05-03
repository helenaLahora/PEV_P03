using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour //pot mostrar qualsevol di�leg
{

    public static DialogueManager Instance;
    public Animator _animator;

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Speech;
    public TextMeshProUGUI[] Options;//Array de textos amb opcions que te el jugador per clicar

    private DialogueNode _currentNode;

    void Awake() // es com el start, per� abans; es fa servir per fer 1 cop el que es necessiti abans del start. 
    {
        if(Instance == null)
        {
            Instance = this;//Nom�s pot haver una inst�ncia. Una inst�ncia molt f�cil d'acc�s i garanteix que nom�s hi hagi una
        }
        else
        {
            Destroy(this);
        }
    }
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartDialogue(Dialogue dialogue) //mostrar el di�leg nou fet.
    {
        Name.text = dialogue.Name;
        SetNode(dialogue.StartNode);
        Show();
    }

    public void OptionChosen(int number)
    {
        DialogueNode nextNode = _currentNode.Options[number].NextNode;
        SetNode(nextNode);
    }

    private void SetNode(DialogueNode node)
    {
        _currentNode = node;
        Speech.text = node.Speech;
        for (int i = 0; i < Options.Length; i++)
        {
            if (i < node.Options.Count)
            {
                Options[i].transform.parent.gameObject.SetActive(true);
                Options[i].text = node.Options[i].Text;
            }
            else
            {
                Options[i].transform.parent.gameObject.SetActive(false);
            }
        }
    }

    public void Show()
    {
        _animator.SetBool("Show", true);
    }

    // Update is called once per frame
    public void Hide()
    {
        _animator.SetBool("Show", false);
    }
}
