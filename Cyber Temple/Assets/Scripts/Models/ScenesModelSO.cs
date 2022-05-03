using UnityEngine;

[CreateAssetMenu(menuName = "SO/ScenesModel")]
public class ScenesModelSO : ScriptableObject
{
    [SerializeField] private string gameSceneName;
    [SerializeField] private string mainMenuSceneName;

    public string GameSceneName { get => gameSceneName; }
    public string MainMenuSceneName { get => mainMenuSceneName; }
}

