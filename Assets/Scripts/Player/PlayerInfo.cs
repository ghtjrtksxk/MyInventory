using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private PlayerData warriorData;
    [SerializeField] private PlayerData mageData;
    [SerializeField] private PlayerData archerData;

    [SerializeField] private PlayerData characterData;
    public string characterName;



    public string jobInfoPrompt(int jobnumber)
    {
        if (jobnumber == 1)
        {
            characterData = warriorData;
        }
        else if (jobnumber == 2)
        {
            characterData = mageData;
        }
        else if (jobnumber == 3)
        {
            characterData = archerData;
        }

        string str = $"{characterData.playerJobName}\n{characterData.jobDescription}\n{characterData.jobDifficulty}";
        return str;
    }


}
