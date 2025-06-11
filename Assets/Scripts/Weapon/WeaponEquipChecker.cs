using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEquipChecker : MonoBehaviour
{
    public WeaponStatData _weaponStatData;

    public bool isEquip = false;

    void Start()
    {
        _weaponStatData = GetComponent<WeaponStatData>();
    }

    public bool CheckJobCorrect()
    {
        return UIManager.Instance._playerInfo.characterJobData.jobId == _weaponStatData._weaponScriptableObject.jobType;
    }
}
