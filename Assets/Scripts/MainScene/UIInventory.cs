using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Image inventoryImage;
    public Image backMainMenuInInventory;

    public Text cantEquipText;

    bool isEquip;

    public void CloseInventory()
    {
        inventoryImage.gameObject.SetActive(false);
        backMainMenuInInventory.gameObject.SetActive(false);

        UIManager.Instance._uiMainMenu.inventoryButton.gameObject.SetActive(true);
        UIManager.Instance._uiMainMenu.statusButton.gameObject.SetActive(true);
    }

    public void ClickInventoryIcon(GameObject buttonObj)
    {
        WeaponEquipChecker _weaponEquipChecker = buttonObj.GetComponentInParent<WeaponEquipChecker>();

        if (_weaponEquipChecker.CheckJobCorrect())
        {
            isEquip = true;

            buttonObj.transform.GetChild(0).GetComponent<Image>().enabled = isEquip;
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