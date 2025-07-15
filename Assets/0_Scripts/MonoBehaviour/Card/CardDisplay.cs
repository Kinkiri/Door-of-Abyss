using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public TextMeshProUGUI cardName; // 卡牌名称
    public TextMeshProUGUI cardDescription; // 卡牌描述
    public TextMeshProUGUI cardCost; // 卡牌费用
    public bool isUnit; // 是否为单位
    public Card_Unit unit; // 单位
    public GameObject unitPanel; // 单位面板
    public TextMeshProUGUI cardAtk; // 单位攻击力
    public TextMeshProUGUI cardHealth; // 单位生命值
    void Start()
    {
        card.UpdateDisplay += RefreshCard; // 订阅事件
        cardData = card.data;
        if (cardData.cardType == CardType.单位)
        {
            isUnit = true;
            unit = card as Card_Unit;
            unitPanel.SetActive(true);
        }
        DisplayCard();
    }
    public void DisplayCard() // 显示初始卡牌信息
    {
        cardImage.sprite = cardData.cardImage;
        cardName.text = cardData.cardName;
        RefreshCard();
    }
    public void RefreshCard() // 刷新动态卡牌信息
    {
        cardDescription.text = card.GetDescription();
        cardCost.text = card.currentCost.ToString();
        if (isUnit)
        {
            cardAtk.text = unit.attack.ToString();
            cardHealth.text = unit.currentHealth.ToString();
        }
    }
    private void OnDestroy()
    {
        card.UpdateDisplay -= RefreshCard;
    }
}
