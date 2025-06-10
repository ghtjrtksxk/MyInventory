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

    [SerializeField] private GameObject characterObject;

    [SerializeField] private GameObject inputPlayerNameField;
    [SerializeField] private GameObject setPlayerNameText;

    [SerializeField] private Text jobInfoText;

    public int jobImageNumber = 1;

    public void ShowArrowImage()
    {
        leftArrow.SetActive(true);
        rightArrow.SetActive(true);
    }

    public void ClearArrowImage()
    {
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
    }

    public void ShowCharacterImage()
    {
        ClearCharacterImage();

        if (jobImageNumber == 1)
        {
            warriorImage.SetActive(true);
        }
        else if (jobImageNumber == 2)
        {
            mageImage.SetActive(true);
        }
        else if (jobImageNumber == 3)
        {
            archerImage.SetActive(true);
        }

        jobInfoText.text = characterObject.GetComponent<PlayerInfo>().JobInfoPrompt(jobImageNumber);
    }

    public void ClearCharacterImage()
    {
        warriorImage.SetActive(false);
        mageImage.SetActive(false);
        archerImage.SetActive(false);

        jobInfoText.text = " ";
    }

    public void ShowInputPlayerNameImage()
    {
        inputPlayerNameField.SetActive(true);
        setPlayerNameText.SetActive(true);
    }   

}
