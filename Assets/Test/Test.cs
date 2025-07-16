using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 测试脚本,用于测试一些功能
/// </summary>
public class Test : MonoBehaviour
{
    public TMP_InputField cardID;
    public void CreateCardTest()
    {
        Player testPlayer = new Player();
        CardManager.Instance.CreatCardObject(cardID.text, testPlayer);
    }
}
