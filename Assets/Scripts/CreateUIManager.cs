using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateUIManager : MonoBehaviour
{
    public GameObject selectJobObjects;

    private ShowCreateSceneUI _showCreateSceneUI;

    bool isCharacterImage = false;

    private void Start()
    {
        _showCreateSceneUI = selectJobObjects.GetComponent<ShowCreateSceneUI>();
    }
    public void CreateButtonClick()
    {
        if (!isCharacterImage)
        {
            _showCreateSceneUI.ShowArrowImage();
            _showCreateSceneUI.ShowCharacterImage();

            isCharacterImage = true;
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void LeftfArrowClick()
    {
        if (_showCreateSceneUI.jobImageNumber > 1)
        {
            _showCreateSceneUI.jobImageNumber--;
            _showCreateSceneUI.ShowCharacterImage();
        }
    }

    public void RightArrowClick()
    {
        if (_showCreateSceneUI.jobImageNumber < 3)
        {
            _showCreateSceneUI.jobImageNumber++;
            _showCreateSceneUI.ShowCharacterImage();
        }
    }

}
