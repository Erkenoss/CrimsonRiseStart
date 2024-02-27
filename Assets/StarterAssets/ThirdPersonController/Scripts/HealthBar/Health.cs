using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int curHealth = 0;
    public int maxHealth = 100;
    public HealthBar healthBar;
    public bool testDamage;
    void Start()
    {
        testDamage = false;
        curHealth = maxHealth;
    }
    public void DamagePlayer(int damage)
    {
        curHealth -= damage;
        healthBar.SetHealth(curHealth);
        testDamage = true;
    }
    public void AddLife(int recover)
    {
        curHealth += recover;
        healthBar.SetHealth(curHealth);
    }
}