using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonHealth : MonoBehaviour
{
    public int dh;  //the health of the Dragon
    public Animator animator;


    void Start()
    {
        dh = 100;
    }

    public void TakeDamage(int dmgs)
    {
        dh -= dmgs;
        if (dh <= 0)
        {
            //Animation death
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled  = false;
        }
        else
        {
            //Animation take damage
            animator.SetTrigger("damage");
        }
    }
}
