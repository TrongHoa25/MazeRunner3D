using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
public class fixmenu : MonoBehaviour
{
    public GameObject menu;
    public void changeScene(int sceneIndex)
    {
        menu.SetActive(false);
        UnitySceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1;
    }
}

