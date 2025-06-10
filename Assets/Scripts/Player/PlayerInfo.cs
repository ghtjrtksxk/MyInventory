using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private PlayerJobData warriorData;
    [SerializeField] private PlayerJobData mageData;
    [SerializeField] private PlayerJobData archerData;

    public PlayerJobData characterData;

    private PlayerStatData _characterStat;
    public string characterName;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        _characterStat = GetComponent<PlayerStatData>();
    }

    public string JobInfoPrompt(int jobnumber)
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

    public void SetCharacterInfo()
    {
        if (characterData.jobId == 1)
        {
            //_characterStat.attack +=
        }
        else if (characterData.jobId == 2)
        {

        }
        else if (characterData.jobId == 3)
        {
            _characterStat.attack += 5;
        }
    }
}
