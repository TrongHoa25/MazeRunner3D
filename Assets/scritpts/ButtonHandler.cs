using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
   
    public GameObject visi, invisi;
   
    
    public void ResumeBtn()
    {
        visi.SetActive(false);
        invisi.SetActive(true);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        visi.SetActive(false);
        invisi.SetActive(true);
        Time.timeScale = 0;
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
