using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 卡牌库
/// </summary>
public class CardLibrary : MonoBehaviour
{
    public static CardLibrary Instance { get; private set; }
    void Awake()
    {
        Instance = this;
    }

    [Header("注册卡牌列表")]
    public List<CardData> cardList = new();
    public Dictionary<string, CardData> cardDict = new();
    public Dictionary<string, System.Type> cardTypeDict = new();
    void Start()
    {
        // 加载卡牌数据
        foreach (CardData card in cardList)
        {
            cardDict.Add(card.cardID, card);
            cardTypeDict.Add(card.cardID, System.Type.GetType(card.entityTypeName));
            Debug.Log(card.cardID + " " + System.Type.GetType(card.entityTypeName));
        }
        Debug.Log($"共加载了{cardList.Count}张卡牌");
    }
    public static CardData GetCardData(string cardID) // 查询卡牌数据
    {
        if (Instance.cardDict.ContainsKey(cardID))
        {
            return Instance.cardDict[cardID];
        }
        else
        {
            Debug.LogError($"卡牌{cardID}不存在");
            return null;
        }
    }
    public static System.Type GetCardType(string cardID) // 查询卡牌类型
    {
        if (Instance.cardTypeDict.ContainsKey(cardID))
        {
            return Instance.cardTypeDict[cardID];
        }
        else
        {
            Debug.LogError($"卡牌{cardID}不存在");
            return null;
        }
    }
}
