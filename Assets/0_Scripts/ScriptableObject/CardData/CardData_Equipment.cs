using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 装备卡数据
/// </summary>
[CreateAssetMenu(fileName = "新建装备卡", menuName = "Data/装备卡")]
public class CardData_Equipment : CardData
{
    [Header("装备参数")]
    public int healthIncrease; // 生命值增加
    public int attackIncrease; // 攻击力增加
    void OnValidate()
    {
        cardType = CardType.装备;
    }
}
