using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 卡牌数据
/// </summary>
[CreateAssetMenu(fileName = "New CardData", menuName = "Data/CardData")]
public class CardData : ScriptableObject
{
    [Header("配置参数")]
    public string cardName; // 卡牌名称
}
