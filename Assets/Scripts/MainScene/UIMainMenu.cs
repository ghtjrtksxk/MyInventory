using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _character;

    [SerializeField] private Image characterImage;

    [SerializeField] private Sprite warriorSprite;
    [SerializeField] private Sprite mageSprite;
    [SerializeField] private Sprite archerSprite;

    [SerializeField] private Text characterDataText;

    [SerializeField] private Button inventoryButton;
    [SerializeField] private Button statusButton;

    void Start()
    {
        _character = GameObject.Find("Character");

        SetCharacterImage();
        ShowCharacterDataText();
        ShowButtonImage();
    }

    void SetCharacterImage()
    {
        characterImage.gameObject.SetActive(true);

        if (_character.GetComponent<PlayerInfo>().characterData.jobId == 1)
        {
            characterImage.sprite = warriorSprite;
        }
        else if (_character.GetComponent<PlayerInfo>().characterData.jobId == 2)
        {
            characterImage.sprite = mageSprite;
        }
        else if (_character.GetComponent<PlayerInfo>().characterData.jobId == 3)
        {
            characterImage.sprite = archerSprite;
        }
    }

    void ShowCharacterDataText()
    {
        characterDataText.text = $"¿Ã∏ß : {_character.GetComponent<PlayerInfo>().characterName} " +
            $"\n{_character.GetComponent<PlayerInfo>().characterData.playerJobName}"; 
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
    }

    public void OpenStatus()
    {
        inventoryButton.gameObject.SetActive(false);
        statusButton.gameObject.SetActive(false);
    }
}
