using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int curHealth = 0;
    public int maxHealth = 1000;
    public HealthBar healthBar;
    public Animator animator;
    public GameOverScreen gameOverScreen;

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
            GameOver();
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

    public void GameOver()
    {
        gameOverScreen.Setup();
    }
}