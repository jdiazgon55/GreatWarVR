using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    void Start()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        Debug.Log("Bye: ");
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        Debug.Log("Hello: ");
    }
}