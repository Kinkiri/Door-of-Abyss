using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "New UnitCardData", menuName = "Data/UnitCardData")]
public class UnitCardData : CardData
{
    public int attack; // 攻击力
    public int health; // 生命值
    public UnitType unitType; // 单位类型
    public GameObject unitPrefab; // 单位预制体
}
