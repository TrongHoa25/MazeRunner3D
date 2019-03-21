using UnityEngine.Audio;
using UnityEngine;

public class KeyHandler : MonoBehaviour
{
    public GameObject key;
    public AudioClip clip;
    //public AudioSource audio;
    public PlayerKey playerkey;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerkey.setKey();
            AudioSource.PlayClipAtPoint(clip,key.transform.position);
            Destroy(gameObject);
        }
    }
}
