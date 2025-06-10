using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "New PlayerData")]
public class PlayerData : ScriptableObject
{
    [Header("Info")]
    public string playerJobName;
    public string jobDescription;
    public string jobDifficulty;
}
