using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 卡牌工厂
/// </summary>
public class CardFactory : MonoBehaviour
{
    public static CardFactory Instance { get; private set; }
    void Awake()
    {
        Instance = this;
    }


    /// <summary>
    /// 根据卡牌ID创建卡牌实例
    /// </summary>
    /// <returns>Card类型实例</returns>
    public static Card CreatCardByID(string cardID, Player owner)
    {
        CardData data = CardLibrary.GetCardData(cardID); // 获取卡牌数据
        if (data == null) // 卡牌不存在
        {
            Debug.LogError("卡牌不存在：" + cardID);
            return null;
        }
        // 通过反射创建卡牌实例
        return Activator.CreateInstance(CardLibrary.GetCardType(cardID), data, owner) as Card;
    }
}
