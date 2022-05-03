using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuView : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void PlayGame()
    {
        SceneController.Instance.LoadGameScene();
    }

    private void ExitGame()
    {
        print("Quitting game...");
        Application.Quit();
    }
}
