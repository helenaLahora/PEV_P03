using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManage : MonoBehaviour
{

    public static DialogManage Instance; //esta parte falla
    private Animator _animator;

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Speech;
    public TextMeshProUGUI[] Options;

    private DialogNode _currentNode;
    private GameObject talker;

    void Awake() //el Awake falla, no salta el Trigger al acercarse el player T_T
    {
        if (Instance == null)
        {
            Instance = this;
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

    public void StartDialog(Dialog dialog, GameObject _talker)
    {
        Name.text = dialog.Name;
        SetNode(dialog.StartNode);
        Show();
    }

    public void OptionChosen(int number, GameObject _talker)
    {
        DialogNode nextNode = _currentNode.Options[number].NextNode;
        if (nextNode is EndNode)
        {
            EndNode endNode = nextNode as EndNode;
            endNode.EndAction(_talker);
            Hide();
        }
        else
        {

            SetNode(nextNode);
        }
    }

    private void SetNode(DialogNode node)
    {
        _currentNode = node;
        Speech.text = node.Speech;

        //este bucle es para que se produzcan de forma automatica tantos botones
        //como opciones hay, y ahorrarnos botones inutiles o tener que hacerlo
        //de forma manual
        for (int i = 0; i < Options.Length; i++)
        {
            if (i < node.Options.Count)
            {
                Options[i].transform.parent.gameObject.SetActive(true); //si estas dentro de la lista te activas
                Options[i].text = node.Options[i].Text;
            }
            else
            {
                Options[i].transform.parent.gameObject.SetActive(false); //si no, no te activas
            }
        }
    }

    public void Show()
    {
        _animator.SetBool("Show", true);
    }

    public void Hide()
    {
        _animator.SetBool("Show", false);
    }
}
