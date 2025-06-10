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
            $"���ݷ� : {characterStat.attack}\n" +
            $"���� : {characterStat.defence}\n" +
            $"ü�� : {characterStat.hp}\n" +
            $"���� : {characterStat.mp}\n" +
            $"���� ��� : {characterStat.gold} G";
    }
}