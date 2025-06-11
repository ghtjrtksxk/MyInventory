using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Image inventoryImage;
    public Image backMainMenuInInventory;

    public Text cantEquipText;

    bool isEquip = false;

    public void CloseInventory()
    {
        inventoryImage.gameObject.SetActive(false);
        backMainMenuInInventory.gameObject.SetActive(false);

        UIManager.Instance._uiMainMenu.inventoryButton.gameObject.SetActive(true);
        UIManager.Instance._uiMainMenu.statusButton.gameObject.SetActive(true);
    }

    public void ClickInventoryIcon(GameObject buttonObj)
    {
        if (buttonObj.GetComponentInParent<WeaponEquipChecker>().CheckEquipable() == true)
        {
            Image[] images = buttonObj.GetComponentsInChildren<Image>(true);

            foreach (Image img in images)
            {
                if (!isEquip)
                {
                    img.enabled = true;
                    isEquip = true;
                }
                else
                {
                    img.enabled = false;
                    isEquip = false;
                }
            } 
        }
        else
        {
            StartCoroutine(ActivateForTwoSeconds());
        }
    }

    IEnumerator ActivateForTwoSeconds()
    {
        cantEquipText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        cantEquipText.gameObject.SetActive(false);
    }
}