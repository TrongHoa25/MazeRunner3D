using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
   
    public GameObject pauseMenu, controller;
   
    
    public void ResumeBtn()
    {
        pauseMenu.SetActive(false);
        controller.SetActive(true);
        Time.timeScale = 1;
    }
    
    public void restartBtn()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }

    public void quitBtn()
    {
        Application.Quit();
    }
}
