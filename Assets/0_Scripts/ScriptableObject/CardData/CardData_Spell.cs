using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 魔法卡数据
/// </summary>
[CreateAssetMenu(fileName = "新建魔法卡", menuName = "Data/魔法卡")]
public class CardData_Spell : CardData
{
    [Header("魔法参数")]
    public TargetType targetType; // 目标类型
    public TargetRange targetRange; // 目标范围
    [Header("可选参数")]
    public int damage; // 伤害值
    public int heal; // 治疗值
    public Element element; // 元素类型
    void OnValidate()
    {
        cardType = CardType.魔法;
        base.entityTypeName = "Card_Spell";
    }
}
