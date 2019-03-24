using UnityEngine;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour
{
    public GameObject menu;
    public GameObject controller;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            menu.SetActive(true);
            controller.SetActive(false);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
