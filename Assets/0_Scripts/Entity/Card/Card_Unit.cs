using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单位卡
/// </summary>
public class Card_Unit : Card
{
    public int currentHealth;
    public int maxHealth;
    public int attack;
    public bool isPlaced; // 
    static Card_Unit()
    {

    }
    public Card_Unit(CardData data, Player owner) : base(data, owner)
    {
        CardData_Unit data_unit = (CardData_Unit)data;
        maxHealth = data_unit.initialHealth;
    }
    public virtual void OnPlaced()
    {
        currentHealth = maxHealth;
    }
}
