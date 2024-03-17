using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealerLeft : MonoBehaviour
{
    bool canDealDamage;
    public float legLength;
    public ElyHealth health;

    void Update()
    {
        if (canDealDamage)
        {
            RaycastHit hit;
            int layerMask = 1 << 9;
            if (Physics.Raycast(transform.position, -transform.up, out hit, legLength, layerMask))
            {
                DealDamage();
            }
        }
    }

    public void StartDealDamageLeft()
    {
        canDealDamage = true;
    }

    public void EndDealDamageLeft()
    {
        canDealDamage = false;
    }

    public void DealDamage()
    {
        health.TakeDamage(10);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position - transform.up * legLength);
    }
}
