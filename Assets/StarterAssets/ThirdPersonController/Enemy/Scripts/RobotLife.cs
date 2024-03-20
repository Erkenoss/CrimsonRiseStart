using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotLife : MonoBehaviour
{
    public int robotLife;
    public Animator animator;
    public Health playerHealth;
    // public List<Rigidbody> Kinematic = new List<Rigidbody>();
    // public List<Collider> RagdollParts = new List<Collider>();

    // Start is called before the first frame update
    void Start()
    {
        robotLife = 100;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void TakeDamage(int dmgs)
    {
        robotLife -= dmgs;
        if (robotLife <= 0)
        {
            //Animation death
            animator.SetTrigger("Die");
            GetComponent<Collider>().enabled  = false;
            StartCoroutine(Destroy());
        }
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
    // private void SetRagdollParts()
    // {
    //     //Set all collider
    //     Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();
    //     //Set all rigidbody
    //     Rigidbody[] bodies = this.gameObject.GetComponentsInChildren<Rigidbody>();

    //     foreach(Collider col in colliders)
    //     {
    //         if (col.gameObject != this.gameObject)
    //         {
    //             col.isTrigger = true;
    //             RagdollParts.Add(col);
    //         }
    //     }
    //     foreach(Rigidbody body in bodies)
    //     {
    //         if (body.gameObject != this.gameObject)
    //         {
    //             body.isKinematic = true;
    //             Kinematic.Add(body);
    //         }
    //     }
    // }
    // private void TurnOnRagdoll()
    // {
    //     //Enable the possibility to move and acces to the character controller
    //     animator.enabled = false;
    //     animator.avatar = null;

    //     foreach (Collider col in RagdollParts)
    //     {
    //         col.isTrigger = false;
    //     }
    //     foreach (Rigidbody body in Kinematic)
    //     {
    //         body.isKinematic = false;
    //     }
    // }
}
