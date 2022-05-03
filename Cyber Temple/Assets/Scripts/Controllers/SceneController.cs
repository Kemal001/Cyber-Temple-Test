using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Singleton<SceneController>
{
    [SerializeField] private ScenesModelSO scenesModel;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(scenesModel.GameSceneName);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(scenesModel.MainMenuSceneName);
    }
}
