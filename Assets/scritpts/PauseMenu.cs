using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject controller;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    public void Pausebtn()
    {
        controller.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    
}
