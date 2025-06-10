using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultStatData", menuName = "New DefaultStatData")]
public class DefaultStatData : ScriptableObject
{
    [Header("DefaultStat Info")]
    public int defaultAttack;
    public int defaultDefence;
    public int defaultHp;
    public int defaultMp;
    public int defaultGold;
}
