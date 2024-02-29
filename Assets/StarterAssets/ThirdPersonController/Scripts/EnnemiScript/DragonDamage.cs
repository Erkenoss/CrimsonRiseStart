using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragonDamage : MonoBehaviour
{
    public CharactersAttacks charactersAttacks;
    public Animator animator;
    public AttackState attackState;
    public bool isAttack;

    private void Awake ()
    {
        charactersAttacks = GetComponent<CharactersAttacks>();
        animator = GetComponent<Animator>();
        attackState = animator.GetBehaviour<AttackState>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (animator.GetBool("isAttacking") == true)
            {
                other.GetComponent<Health>().DamagePlayer(10);
            }
        }
    }
}
