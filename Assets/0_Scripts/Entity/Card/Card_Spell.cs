using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 魔法卡
/// </summary>
public class Card_Spell : Card
{
    public TargetType targetType;
    public TargetRange targetRange;

    public int damage;
    public int heal;
    public Element element;
    public Card_Spell(CardData data, Player owner) : base(data, owner)
    {
        CardData_Spell spell = (CardData_Spell)data;
        damage = spell.damage;
        heal = spell.heal;
        element = spell.element;
        targetType = spell.targetType;
        targetRange = spell.targetRange;
    }



}
