using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
/// <summary>
/// 卡牌显示器
/// </summary>
public class CardDisplay : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Card card;
    public CardData cardData;
    public Image cardImage; // 卡面
    public TextMeshProUGUI cardName; // 卡牌名称
    public TextMeshProUGUI cardDescription; // 卡牌描述
    public TextMeshProUGUI cardTabs; // 卡牌标签
    public TextMeshProUGUI cardCost; // 卡牌费用
    public bool isUnit; // 是否为单位
    public bool isEquip; // 是否为装备
    public Card_Unit unit; // 单位
    public GameObject unitPanel; // 单位面板
    public TextMeshProUGUI cardAtk; // 单位攻击力
    public TextMeshProUGUI cardHealth; // 单位生命值
    public GameObject discriptionPanel; // 描述面板
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
        if (cardData.cardType == CardType.装备)
        {
            isEquip = true;
            CardData_Equipment equip = cardData as CardData_Equipment;
            unitPanel.SetActive(true);
            cardAtk.text = equip.attackIncrease.ToString();
            cardHealth.text = equip.healthIncrease.ToString();
        }
        DisplayCard();
    }
    public void DisplayCard() // 显示初始卡牌信息
    {
        cardImage.sprite = cardData.cardImage;
        cardName.text = cardData.cardName;
        cardTabs.text = GetCardTabs();
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
    public string GetCardTabs() // 获取卡牌标签列表
    {
        string tabs = cardData.cardType.ToString() + "\n"
            + cardData.cardRarity.ToString() + "\n"
            + cardData.worldTab.ToString() + "\n"
            + cardData.forceTab.ToString() + "\n";
        if (cardData.cardType == CardType.单位)
        {
            CardData_Unit unit = cardData as CardData_Unit;
            tabs += unit.unitType.ToString() + "\n"
                + unit.element.ToString() + "\n";
        }
        foreach (NormalTab tab in cardData.normalTabs)
        {
            tabs += tab.ToString() + "\n";
        }
        return tabs;
    }
    private void OnDestroy()
    {
        card.UpdateDisplay -= RefreshCard;
    }

    public void OnPointerEnter(PointerEventData eventData) // 鼠标移入时显示描述面板
    {
        discriptionPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData) // 鼠标移出时隐藏描述面板
    {
        discriptionPanel.SetActive(false);
    }
}
