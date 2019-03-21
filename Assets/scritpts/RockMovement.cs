using UnityEngine.Audio;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audio;
    public Rigidbody rock;
    public BoxCollider trigger;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            rock.AddForce(0, 0, -1000000f);
            audio.PlayOneShot(clip);
        }
    }
}
