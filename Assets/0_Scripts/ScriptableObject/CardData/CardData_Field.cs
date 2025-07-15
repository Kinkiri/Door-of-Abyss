using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 场地卡数据
/// </summary>
[CreateAssetMenu(fileName = "新建场地卡", menuName = "Data/场地卡")]
public class CardData_Field : CardData
{
    void OnValidate()
    {
        cardType = CardType.场地;
        base.entityTypeName = "Card_Field";
    }
}
