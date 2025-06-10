using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public PlayerData data;

    public string jobInfoPrompt()
    {
        string str = $"{data.playerJobName}\n{data.jobDescription}\n{data.jobDifficulty}";
        return str;
    }
}
