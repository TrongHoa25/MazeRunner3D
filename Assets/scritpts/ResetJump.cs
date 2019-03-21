using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetJump : MonoBehaviour
{
    public PlayerDamage player;
    bool isreseted = false;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (isreseted == false)
        {
            if (other.gameObject.tag == "Player")
            {
                player.resetJump();
                isreseted = true;
            }
        }
        
    }
}
