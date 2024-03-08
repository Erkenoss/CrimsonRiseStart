using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragonDamage : MonoBehaviour
{
    public Animator animator;
    public float damageTimer = 1.30f;
    public float attackRange = 2f;

    private void Awake ()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (damageTimer > 0)
        {
            damageTimer -= Time.deltaTime;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (damageTimer <= 0)
        {
            if (IsTargetInRange())
            {
                other.GetComponent<Health>().DamagePlayer(5);
                damageTimer = 1.30f;
                Invoke(nameof(ResetCooldown), damageTimer);
            }
        }
    }
    private void ResetCooldown()
    {
        damageTimer = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        damageTimer = 0;
    }


    // private void OnTriggerExit(Collider other)
    // {

    // }

    private bool IsTargetInRange()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            Transform player = playerObject.transform;
            float distance = Vector3.Distance(transform.position, player.position);
            return distance <= attackRange;
        }
        return false;
    }
}
