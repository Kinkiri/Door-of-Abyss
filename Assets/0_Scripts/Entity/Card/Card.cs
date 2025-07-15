using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 卡牌基类
/// </summary>
public abstract class Card
{
    public CardData data;
    public Player owner;
    public uint currentCost;
    public event Action UpdateDisplay; // 卡牌状态变化时触发的事件,通知外部更新显示
    public Card(CardData data, Player owner)
    {
        this.data = data;
        this.owner = owner;
        this.currentCost = data.baseCost;
    }
    public virtual bool CanPlay()
    {
        return owner.currentCost >= currentCost;
    }
    /// <summary>
    /// 获取动态卡牌描述
    /// </summary>
    /// <returns>动态描述</returns>
    public virtual string GetDescription()
    {
        return data.cardDescription;
    }
    public virtual void OnPlay()
    { 
        Debug.Log("打出了" + data.cardID);
    }
}
