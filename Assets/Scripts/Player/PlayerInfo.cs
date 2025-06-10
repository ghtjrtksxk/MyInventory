using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private PlayerJobData warriorData;
    [SerializeField] private PlayerJobData mageData;
    [SerializeField] private PlayerJobData archerData;

    [SerializeField] private DefaultStatData warriorDefaultStat;
    [SerializeField] private DefaultStatData mageDefaultStat;
    [SerializeField] private DefaultStatData archerDefaultStat;

    public PlayerJobData characterJobData;

    public PlayerStatData _characterStat;
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
            characterJobData = warriorData;
        }
        else if (jobnumber == 2)
        {
            characterJobData = mageData;
        }
        else if (jobnumber == 3)
        {
            characterJobData = archerData;
        }

        string str = $"{characterJobData.playerJobName}\n{characterJobData.jobDescription}\n{characterJobData.jobDifficulty}";
        return str;
    }

    public void SetCharacterInfo()
    {
        if (characterJobData.jobId == 1)
        {
            _characterStat.attack += warriorDefaultStat.defaultAttack;
            _characterStat.defence += warriorDefaultStat.defaultDefence;
            _characterStat.hp += warriorDefaultStat.defaultHp;
            _characterStat.mp += warriorDefaultStat.defaultMp;
            _characterStat.gold += warriorDefaultStat.defaultGold;

        }
        else if (characterJobData.jobId == 2)
        {
            _characterStat.attack += mageDefaultStat.defaultAttack;
            _characterStat.defence += mageDefaultStat.defaultDefence;
            _characterStat.hp += mageDefaultStat.defaultHp;
            _characterStat.mp += mageDefaultStat.defaultMp;
            _characterStat.gold += mageDefaultStat.defaultGold;
        }
        else if (characterJobData.jobId == 3)
        {
            _characterStat.attack += archerDefaultStat.defaultAttack;
            _characterStat.defence += archerDefaultStat.defaultDefence;
            _characterStat.hp += archerDefaultStat.defaultHp;
            _characterStat.mp += archerDefaultStat.defaultMp;
            _characterStat.gold += archerDefaultStat.defaultGold;
        }
    }
}
