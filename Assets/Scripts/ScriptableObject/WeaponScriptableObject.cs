using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JobType
{
    Warrior,
    Mage,
    Archer
}

[CreateAssetMenu(fileName = "WeaponStatData", menuName = "New WeaponStatData")]
public class WeaponScriptableObject : ScriptableObject
{
    [Header("WeaponStat Info")]
    public JobType jobType;
    public int WeaponStatAttack;
    public int WeaponStatDefence;
    public int WeaponStatHp;
    public int WeaponStatMp;
}
