using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单位卡数据
/// </summary>
[CreateAssetMenu(fileName = "新建单位卡", menuName = "Data/单位卡")]
public class CardData_Unit : CardData
{
    [Header("单位参数")]
    public int attack; // 攻击力
    public int maxHealth; // 最大生命值
    public UnitType unitType; // 单位类型
    public Element element; // 元素类型
    void OnValidate()
    {
        cardType = CardType.单位;
    }
}
