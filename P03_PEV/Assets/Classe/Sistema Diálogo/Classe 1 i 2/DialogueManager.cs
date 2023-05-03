using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public static DialogueManager Instance;
    public Animator _animator;

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Speech;
    public TextMeshProUGUI[] Options;//Array de textos amb opcions que te el jugador per clicar

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
