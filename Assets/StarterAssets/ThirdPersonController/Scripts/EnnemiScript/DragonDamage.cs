using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragonDamage : MonoBehaviour
{
    public Animator animator;
    public bool canDealDamage;
    public List<Collider> RagdollParts = new List<Collider>();

    private void Awake ()
    {
        canDealDamage = false;
        animator = GetComponent<Animator>();
        setRagdollParts();
    }

    private void setRagdollParts()
    {
        Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();

        foreach(Collider c in colliders)
        {
            c.isTrigger = true;
            RagdollParts.Add(c);
        }
    }

    private void FixedUpdate()
    {
        canDealDamage = animator.GetBool("isAttacking");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsRagdollPartCollidingWithPlayer(RagdollParts))
        {
            if (other.gameObject.tag == "Player")
            {
                if (canDealDamage)
                {
                    other.gameObject.GetComponent<Health>().DamagePlayer(20);
                }
            }
        }
    }

    private bool IsRagdollPartCollidingWithPlayer(List<Collider> ragdollParts)
    {
        foreach (Collider ragdollPart in ragdollParts)
        {
            Collider[] playerColliders = GameObject.FindGameObjectWithTag("Player").GetComponents<Collider>();

            foreach (Collider playerCollider in playerColliders)
            {
                if (ragdollPart.bounds.Intersects(playerCollider.bounds))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void OnTriggerExit(Collider other)
    {
        canDealDamage = false;
    }
}
