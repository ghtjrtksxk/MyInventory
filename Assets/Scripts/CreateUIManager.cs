using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateUIManager : MonoBehaviour
{
    [SerializeField] private GameObject selectJobObjects;
    private ShowCreateSceneUI _showCreateSceneUI;

    [SerializeField] private Text playerName;

    bool isCharacterImage = false;
    bool isPlayerName = false;

    private void Start()
    {
        _showCreateSceneUI = selectJobObjects.GetComponent<ShowCreateSceneUI>();
    }
    public void CreateButtonClick()
    {
        if (!isCharacterImage)
        {
            if (!isPlayerName)
            {
                _showCreateSceneUI.ShowArrowImage();
                _showCreateSceneUI.ShowCharacterImage();

                isCharacterImage = true;
                isPlayerName = true;
            }
            else
            {
                UIManager.Instance._playerInfo.characterName = playerName.text;
                UIManager.Instance._playerInfo.AddDefaultStat();
                SceneManager.LoadScene("MainScene");
            }
        }
        else
        {
            _showCreateSceneUI.ClearArrowImage();
            _showCreateSceneUI.ClearCharacterImage();
            _showCreateSceneUI.ShowInputPlayerNameImage();

            isCharacterImage = false;
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
