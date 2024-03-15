using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealerEly : MonoBehaviour
{
    bool canDealDamage;
    public float armLenght;
    public Health health;

    void Start()
    {
        canDealDamage = true;
    }

    void Update()
    {
        if (canDealDamage)
        {
            RaycastHit hit;
            int layerMask = 1 << 7;
            if (Physics.Raycast(transform.position, -transform.up, out hit, armLenght, layerMask))
            {
                DealDamage();
            }
        }
    }

    public void StartDealDamageEly()
    {
        canDealDamage = true;
    }

    public void EndDealDamageEly()
    {
        canDealDamage = false;
    }

    public void DealDamage()
    {
        health.DamagePlayer(3);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position - transform.up * armLenght);
    }
}
