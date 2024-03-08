using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElyHealth : MonoBehaviour
{
    public int eh;  //the health of the Dragon
    public Animator animator;


    void Start()
    {
        eh = 100;
    }

    public void TakeDamage(int dmgs)
    {
        eh -= dmgs;
        if (eh <= 0)
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
    public void AddLife(int recover)
    {
        eh += recover;
    }
}