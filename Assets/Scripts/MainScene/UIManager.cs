using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance { get { return _instance; } }

    public GameObject character;
    public PlayerInfo _playerInfo;

    public GameObject uiMainMenuObject;
    public GameObject uiStatusObject;
    public GameObject uiInventoryObject;

    public UIMainMenu _uiMainMenu;
    public UIStatus _uiStatus;
    public UIInventory _uiInventory;

    private void Awake()
    {
        _instance = this;

        character = GameObject.Find("Character");
        
        if (character == null)
        {
            Debug.Log("ChCreateScene에서 게임을 Play해주세요!!");
        }
        _playerInfo = character.GetComponent<PlayerInfo>();

        _uiMainMenu = uiMainMenuObject.GetComponent<UIMainMenu>();
        _uiStatus= uiStatusObject.GetComponent<UIStatus>();
        _uiInventory = uiInventoryObject.GetComponent<UIInventory>();
    }

    public void ClickInventoryButton()
    {
        _uiMainMenu.OpenInventory();
    }

    public void ClickBackMenuButtonInInventory()
    {
        _uiInventory.CloseInventory();
    }

    public void ClickStatusButton()
    {
        _uiMainMenu.OpenStatus();
    }

    public void ClickBackMenuButtonInStatus()
    {
        _uiStatus.CloseStatus();
    }
}
