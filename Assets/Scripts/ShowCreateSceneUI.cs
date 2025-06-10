using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCreateSceneUI : MonoBehaviour
{
    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;

    [SerializeField] private GameObject warriorImage;
    [SerializeField] private GameObject mageImage;
    [SerializeField] private GameObject archerImage;

    [SerializeField] private Text jobInfoText;

    public int jobImageNumber = 1;

    public void ShowArrowImage()
    {
        leftArrow.SetActive(true);
        rightArrow.SetActive(true);
    }
    public void ShowCharacterImage()
    {
        warriorImage.SetActive(false);
        mageImage.SetActive(false);
        archerImage.SetActive(false);

        if (jobImageNumber == 1)
        {
            warriorImage.SetActive(true);
            jobInfoText.text = warriorImage.GetComponent<PlayerInfo>().jobInfoPrompt();
        }
        else if (jobImageNumber == 2)
        {
            mageImage.SetActive(true);
            jobInfoText.text = mageImage.GetComponent<PlayerInfo>().jobInfoPrompt();
        }
        else if (jobImageNumber == 3)
        {
            archerImage.SetActive(true);
            jobInfoText.text = archerImage.GetComponent<PlayerInfo>().jobInfoPrompt();
        }
    }

}
