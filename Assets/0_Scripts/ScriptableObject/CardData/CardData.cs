using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// 卡牌数据
/// </summary>
public class CardData : ScriptableObject
{
    [Header("基础参数")]
    public string cardID; // 卡牌ID（一般和名称相同，请确保唯一性）
    public string cardName; // 卡牌名称
    public uint baseCost = 0; // 卡牌费用
    public string cardDescription; // 卡牌描述
    public string cardStory; // 卡牌小字
    public bool isDerivative; // 是否是衍生卡牌
    public Rarity cardRarity; // 卡牌稀有度
    public WorldTab worldTab; // 卡牌所属世界标签
    public ForceTab forceTab; // 卡牌所属势力标签
    public List<NormalTab> normalTabs; // 卡牌所属通用标签
    [Header("美术参数")]
    public Sprite cardImage; // 卡牌图片
    [Header("自动参数")]
    public string entityTypeName; // 实体类型名称（请策划不要动这玩意）
    public CardType cardType;// 卡牌类型
}
