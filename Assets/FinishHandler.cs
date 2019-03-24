using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishHandler : MonoBehaviour
{
    public PlayerKey playerkey;
    public GameObject controller;
    public GameObject finishMenuT;
    public GameObject finishMenuF;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(playerkey.getKeysNum() == 3)
            {
                Time.timeScale = 0;
                controller.SetActive(false);
                finishMenuT.SetActive(true);
                
            }
            else
            {
                Time.timeScale = 0;
                controller.SetActive(false);
                finishMenuF.SetActive(true);
            }
        }
    }
}
