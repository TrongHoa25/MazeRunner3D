
using UnityEngine;

public class bedamage : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            anim.SetTrigger("BeDamage");
        }
    }
}
