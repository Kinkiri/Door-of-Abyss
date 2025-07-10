using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// 卡牌数据
/// </summary>
[CreateAssetMenu(fileName = "New CardData", menuName = "Data/CardData")]
public class CardData : ScriptableObject
{
    [Header("配置参数")]
    public string cardName; // 卡牌名称
    public string cardID; // 卡牌ID（请以）
    public Sprite cardImage; // 卡牌图片
    public string cardDescription; // 卡牌描述
    public sbyte baseCost = 0; // 卡牌费用（负值表示回费）
    public string entityTypeName; // 实体类型名称（请策划不要动这玩意）
    public CardType cardType;// 卡牌类型
    public Rarity cardRarity; // 卡牌稀有度
    public List<WorldTab> worldTabs; // 卡牌所属世界标签
    public List<NormalTab> normalTabs; // 卡牌所属通用标签
}
