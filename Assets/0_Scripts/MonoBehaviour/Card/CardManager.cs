using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 卡牌管理器
/// </summary>
public class CardManager : MonoBehaviour
{
    public static CardManager Instance { get; private set; }
    void Awake()
    {
        Instance = this;
    }
    public GameObject cardPrefab;
    public GameObject hand;
    public GameObject deck;

    /// <summary>
    /// 创建卡牌对象并初始化
    /// </summary>
    public void CreatCardObject(string cardID, Player owner)
    {
        Card card = CardFactory.CreatCardByID(cardID, owner); // 创建卡牌实例
        GameObject cardObj = GameObject.Instantiate(cardPrefab, hand.transform); // 创建卡牌对象
        cardObj.GetComponent<CardDisplay>().card = card; // 绑定卡牌实例
    }
}
