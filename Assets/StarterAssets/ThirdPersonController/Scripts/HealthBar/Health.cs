using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int curHealth = 0;
    public int maxHealth = 100;
    public HealthBar healthBar;
    public Animator animator;
    void Start()
    {
        curHealth = maxHealth;
        animator = GetComponent<Animator>();
    }
    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        healthBar.SetHealth(curHealth);
        if (curHealth <= 0)
        {
            animator.SetTrigger("Die");
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            animator.SetTrigger("Damage");
        }
    }
    public void AddLife(int recover)
    {
        curHealth += recover;
        healthBar.SetHealth(curHealth);
    }
}