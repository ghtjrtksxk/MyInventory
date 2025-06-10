using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Image characterImage;

    [SerializeField] private Sprite warriorSprite;
    [SerializeField] private Sprite mageSprite;
    [SerializeField] private Sprite archerSprite;

    [SerializeField] private Text characterDataText;

    public Button inventoryButton;
    public Button statusButton;

    private PlayerInfo playerInfo;

    void Start()
    {
        playerInfo = UIManager.Instance._playerInfo;

        SetCharacterImage();
        ShowCharacterDataText();
        ShowButtonImage();
    }

    void SetCharacterImage()
    {
        characterImage.gameObject.SetActive(true);

        if(playerInfo == null)
        {
            Debug.Log("ChCreateScene에서 게임을 Play해주세요!!");
        }

        if (playerInfo.characterJobData.jobId == 1)
        {
            characterImage.sprite = warriorSprite;
        }
        else if (playerInfo.characterJobData.jobId == 2)
        {
            characterImage.sprite = mageSprite;
        }
        else if (playerInfo.characterJobData.jobId == 3)
        {
            characterImage.sprite = archerSprite;
        }
    }

    void ShowCharacterDataText()
    {
        characterDataText.text = $"이름 : {playerInfo.characterName} " +
            $"\n{playerInfo.characterJobData.playerJobName}"; 
    }
    
    void ShowButtonImage()
    {
        inventoryButton.gameObject.SetActive(true);
        statusButton.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        inventoryButton.gameObject.SetActive(false);
        statusButton.gameObject.SetActive(false);

        UIManager.Instance._uiInventory.inventoryImage.gameObject.SetActive(true);
        UIManager.Instance._uiInventory.backMainMenuInInventory.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        inventoryButton.gameObject.SetActive(false);
        statusButton.gameObject.SetActive(false);

        UIManager.Instance._uiStatus.statusImage.gameObject.SetActive(true);
        UIManager.Instance._uiStatus.backMainMenuInStatus.gameObject.SetActive(true);

        UIManager.Instance._uiStatus.ShowCharacterStatusData();
    }
}
