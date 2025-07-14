using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 卡牌显示器
/// </summary>
public class CardDisplay : MonoBehaviour
{
    public Card card;
    public CardData cardData;
    public Image cardImage; // 卡面
    public Text cardName; // 卡牌名称
    public Text cardDescription; // 卡牌描述
    public Text cardCost; // 卡牌费用

    public Text cardAtk; // 单位攻击力
    public Text cardHealth; // 单位生命值
    void Start()
    {
        
    }
    public void DisplayCard() // 显示初始卡牌信息
    {

    }
    public void RefreshCard() // 刷新动态卡牌信息
    {

    }
}
