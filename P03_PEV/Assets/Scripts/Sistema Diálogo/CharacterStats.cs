using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Character")]
public class CharacterStats : ScriptableObject
{
    public float Stamina;
    public float Luck;
    public float Attack;
    public float Defense;

    public string Name;
    public Sprite Image;
}
