using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Image inventoryImage;
    public Image backMainMenuInInventory;

    public Text cantEquipText;

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
            _weaponEquipChecker.isEquip = !_weaponEquipChecker.isEquip;

            buttonObj.transform.GetChild(0).GetComponent<Image>().enabled = _weaponEquipChecker.isEquip;
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