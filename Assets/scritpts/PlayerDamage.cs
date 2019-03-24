
using UnityEngine;
using System.Collections;
public class PlayerDamage : MonoBehaviour
{
    public GameObject gameovermenu;
    public Rigidbody player;
    public Animator anim;
    // Start is called before the first frame update
    bool jumped = false;
    int jumpcount = 0;

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "rock")
        {
            anim.SetTrigger("IsDamaged");
            gameovermenu.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
    public void resetJump()
    {
        jumpcount = 0;
        jumped = false;
    }
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "jumppad"){
            if(jumpcount < 4){
                if (jumped == false)
                {
                    player.AddForce(0, 1800f, 0);
                    player.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
                    jumped = true;
                    //Debug.Log("collision");
                }
                else
                {
                    player.constraints = RigidbodyConstraints.None;
                    player.freezeRotation = true;
                    jumped = false;
                }
                jumpcount++;
                
            } 
        }
    }
}
