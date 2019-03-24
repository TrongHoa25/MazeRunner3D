
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
public class SceneManager : MonoBehaviour
{
   
    public void changeScene(int sceneIndex)
    {
        UnitySceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1;
    }
}
