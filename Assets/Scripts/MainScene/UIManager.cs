using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance { get { return _instance; } }

    public GameObject uiMainMenuObject;
    public GameObject uiStatusObject;
    public GameObject uiInventoryObject;

    public UIMainMenu _uiMainMenu;
    public UIStatus _uiStatus;
    public UIInventory _uiInventory;

    private void Start()
    {
        _instance = this;

        _uiMainMenu = uiMainMenuObject.GetComponent<UIMainMenu>();
        _uiStatus= uiStatusObject.GetComponent<UIStatus>();
        _uiInventory = uiInventoryObject.GetComponent<UIInventory>();
    }

    public void ClickInventoryButton()
    {
        _uiMainMenu.OpenInventory();
    }

    public void ClickStatusButton()
    {
        _uiMainMenu.OpenStatus();
    }
}
