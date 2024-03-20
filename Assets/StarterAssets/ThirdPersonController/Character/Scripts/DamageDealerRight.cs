using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealerRight : MonoBehaviour
{
    bool canDealDamage;
    public float legLength;
    public RobotLife health;

    void Update()
    {
        if (canDealDamage)
        {
            RaycastHit hit;
            int layerMask = 1 << 9;
            if (Physics.Raycast(transform.position, -transform.up, out hit, legLength, layerMask))
            {
                Debug.Log("Hit Robot!");
                DealDamage();
            }
        }
    }

    public void StartDealDamageRight()
    {
        canDealDamage = true;
    }

    public void EndDealDamageRight()
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
