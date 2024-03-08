using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ElyDamage : MonoBehaviour
{
    public Animator animator;
    public bool isAttacking;
    public float cooldown;
    float lasthit;
    public Health playerhealth;

    private void Awake ()
    {
        animator = GetComponent<Animator>();
        playerhealth = GetComponent<Health>();
    }
    private void Update()
    {
        isAttacking = animator.GetBool("isAttacking");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Time.time - lasthit < cooldown)
        {
            return;
        }
        lasthit = Time.time;

        Health otherHealth = other.GetComponent<Health>();
        if (isAttacking && otherHealth != null)
        {
            otherHealth.DamagePlayer(5);
        }
    }
}

