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

    public float GetAttack()
    {
        if(Random.Range(0,100)<Luck)
            return (int)Attack * 2;
        
        return (int)Attack;
    }
}
