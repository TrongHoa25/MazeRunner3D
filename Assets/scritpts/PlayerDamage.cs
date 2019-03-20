
using UnityEngine;
using System.Collections;
public class PlayerDamage : MonoBehaviour
{
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
        }
    }
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "jumppad"){
            if(jumpcount < 6){
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
