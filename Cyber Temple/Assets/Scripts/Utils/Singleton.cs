using UnityEngine;

public class Singleton<T> : MonoBehaviour
    where T : MonoBehaviour
{
    private static MonoBehaviour instance;

    public static T Instance => (T)instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }

        instance = this;

        // Because dont destroy on load does not work on child objects
        transform.SetParent(null);

        DontDestroyOnLoad(gameObject);
    }
}

