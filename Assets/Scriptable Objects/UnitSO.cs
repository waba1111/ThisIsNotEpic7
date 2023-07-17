using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Unit", fileName = "New Unit")]
public class UnitSO : ScriptableObject
{
    [Header("General")]
    public string name;

    public Element element;
    public Role role;
    public int baseRarity;
    
    [Header("Stats")] 
    public int atk;
    public int HP;
    public int def;
    public int spd;
    public float crit;
    public float critDmg = 1.5f;
    public float eff;
    public float ER;
    public float dualAtk = 0.05f;
}

public enum Role
{
    Knight,
    Warrior,
    Mage,
    Ranger,
    Soulwaever,
    Thief
}

public enum Element
{
    Fire,
    Water,
    Earth
}
