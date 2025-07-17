using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
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
    public List<CardData> InputCardList = new();
    private List<CardData> cardList = new();
    public Dictionary<string, CardData> cardDict = new();
    public Dictionary<string, System.Type> cardTypeDict = new();
    void Start()
    {
        ReSetCardList(); // 检查卡牌数据
        LoadCardData(); // 加载卡牌数据
    }
    private void ReSetCardList() // 重置卡牌数据
    {
        // 除掉重复卡和空卡
        cardList = InputCardList.Distinct().Where(card => card!= null).ToList();
        // 排序
        cardList = cardList.OrderBy(card => card.cardID).ToList();
    }
    private void LoadCardData() // 加载卡牌数据
    {
        foreach (CardData data in cardList)
        {
            cardDict.Add(data.cardID, data);
            cardTypeDict.Add(data.cardID, System.Type.GetType(data.entityTypeName));
            Debug.Log(data.cardID + " " + System.Type.GetType(data.entityTypeName));
        }
        Debug.Log($"共加载了{cardList.Count}张卡牌");
    }
    public static CardData GetCardData(string cardID) // 获取卡牌数据
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
    public static System.Type GetCardType(string cardID) // 获取卡牌类型
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
    public static bool HasCard(string cardID) // 是否存在卡牌
    {
        return Instance.cardDict.ContainsKey(cardID);
    }
}
