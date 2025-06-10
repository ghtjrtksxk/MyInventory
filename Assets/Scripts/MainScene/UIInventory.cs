using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Image inventoryImage;
    public Image backMainMenuInInventory;

    public void CloseInventory()
    {
        inventoryImage.gameObject.SetActive(false);
        backMainMenuInInventory.gameObject.SetActive(false);

        UIManager.Instance._uiMainMenu.inventoryButton.gameObject.SetActive(true);
        UIManager.Instance._uiMainMenu.statusButton.gameObject.SetActive(true);
    }
}