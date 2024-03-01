using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragonDamage : MonoBehaviour
{
    public Animator animator;
    public bool canDealDamage;

    private void Awake ()
    {
        canDealDamage = false;
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        canDealDamage = animator.GetBool("isAttacking");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (canDealDamage)
            {
                other.GetComponent<Health>().DamagePlayer(20);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canDealDamage = false;
    }
}
