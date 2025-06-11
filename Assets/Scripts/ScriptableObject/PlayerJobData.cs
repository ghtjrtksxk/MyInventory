using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerJobData", menuName = "New PlayerJobData")]
public class PlayerJobData : ScriptableObject
{
    [Header("Info")]
    public JobType jobId;
    public string playerJobName;
    public string jobDescription;
    public string jobDifficulty;
}
