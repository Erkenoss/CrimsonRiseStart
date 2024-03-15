using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElyHealth : MonoBehaviour
{
    public int eh;  //the health of the Dragon
    public Animator animator;
    public Health playerHealth;
    public List<Collider> RagdollParts = new List<Collider>();
    public List<Collider> CollidingParts = new List<Collider>();
    public List<Rigidbody> Kinematic = new List<Rigidbody>();

    void Start()
    {
        eh = 1000;
        animator = GetComponent<Animator>();
        SetRagdollParts();
    }

    public void TakeDamage(int dmgs)
    {
        eh -= dmgs;
        if (eh <= 0)
        {
            //Animation death
            animator.SetTrigger("die");
            TurnOnRagdoll();
            StartCoroutine(Destroy());
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

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }

    private void SetRagdollParts()
    {
        //Set all collider
        Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();
        //Set all rigidbody
        Rigidbody[] bodies = this.gameObject.GetComponentsInChildren<Rigidbody>();

        foreach(Collider col in colliders)
        {
            if (col.gameObject != this.gameObject)
            {
                col.isTrigger = true;
                RagdollParts.Add(col);
            }
        }
        foreach(Rigidbody body in bodies)
        {
            if (body.gameObject != this.gameObject)
            {
                body.isKinematic = true;
                Kinematic.Add(body);
            }
        }
    }

    private void TurnOnRagdoll()
    {
        //Enable the possibility to move and acces to the character controller
        animator.enabled = false;
        animator.avatar = null;

        foreach (Collider col in RagdollParts)
        {
            col.isTrigger = false;
        }
        foreach (Rigidbody body in Kinematic)
        {
            body.isKinematic = false;
        }
    }
    // private void OnTriggerEnter(Collider col)
    // {
    //     if (RagdollParts.Contains(col))
    //     {
    //         return;
    //     }

    //     if (!CollidingParts.Contains(col))
    //     {
    //         CollidingParts.Add(col);
    //         playerHealth.DamagePlayer(5);
    //     }
    // }

    // private void OnTriggerExit(Collider col)
    // {
    //     CollidingParts.Remove(col);
    // }
}