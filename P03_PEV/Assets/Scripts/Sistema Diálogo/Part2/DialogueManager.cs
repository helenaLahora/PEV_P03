using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Animator _animator;
    // Start is called before the first frame update

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
