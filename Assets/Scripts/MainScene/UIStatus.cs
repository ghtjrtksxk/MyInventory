using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Image statusImage;
    public Image backMainMenuInStatus;

    private PlayerStatData characterStat;
    public Text characterStatText;

    public void CloseStatus()
    {
        statusImage.gameObject.SetActive(false);
        backMainMenuInStatus.gameObject.SetActive(false);

        UIManager.Instance._uiMainMenu.inventoryButton.gameObject.SetActive(true);
        UIManager.Instance._uiMainMenu.statusButton.gameObject.SetActive(true);
    }

    public void ShowCharacterStatusData()
    {
        characterStat = UIManager.Instance._playerInfo._characterStat;

        characterStatText.text = 
            $"공격력 : {characterStat.attack}\n" +
            $"방어력 : {characterStat.defence}\n" +
            $"체력 : {characterStat.hp}\n" +
            $"마나 : {characterStat.mp}\n" +
            $"보유 골드 : {characterStat.gold} G";
    }
}