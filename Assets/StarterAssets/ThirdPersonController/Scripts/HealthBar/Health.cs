using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public CharactersAttacks _charactersAttacks;
    public int curHealth = 0;
    public int maxHealth = 100;
    public HealthBar healthBar;
    void Start()
    {
        _charactersAttacks = GetComponent<CharactersAttacks>();
        curHealth = maxHealth;
    }
    public void DamagePlayer(int damage)
    {
        if (!_charactersAttacks.invincible)
        {
            curHealth -= damage;
            healthBar.SetHealth(curHealth);
        }
    }
}