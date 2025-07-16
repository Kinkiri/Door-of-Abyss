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
    public List<GameObject> handCards = new List<GameObject>();

    /// <summary>
    /// 创建卡牌对象并初始化
    /// </summary>
    public void CreatCardObject(string cardID, Player owner)
    {
        Card card = CardFactory.CreatCardByID(cardID, owner); // 创建卡牌实例
        GameObject cardObj = GameObject.Instantiate(cardPrefab, hand.transform); // 创建卡牌对象
        cardObj.GetComponent<CardDisplay>().card = card; // 绑定卡牌实例
    }
    /// <summary>
    /// 移除卡牌对象
    /// </summary>
    public void RemoveCardObject(GameObject cardObj) // 移除卡牌对象
    {
        GameObject.Destroy(cardObj);
        cardObj.GetComponent<CardDisplay>().card = null;
    }
    // 测试用
    public IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        Player p = new Player();
        Debug.Log("携程测试2s");
    }
}
