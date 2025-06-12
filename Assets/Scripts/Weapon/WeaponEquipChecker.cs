using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponEquipChecker : MonoBehaviour
{
    public WeaponStatData _weaponStatData;

    void Start()
    {
        _weaponStatData = GetComponent<WeaponStatData>();
    }

    public bool CheckJobCorrect()
    {
        return UIManager.Instance._playerInfo.characterJobData.jobId == _weaponStatData._weaponScriptableObject.jobType;
    }
}
