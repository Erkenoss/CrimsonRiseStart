using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemHealTest : MonoBehaviour
{
    public float PickUpRadius = 1f;
    private SphereCollider myCollider;
    public int recover;

    private void Awake()
    {
        myCollider = GetComponent<SphereCollider>();
        myCollider.isTrigger = true;
        myCollider.radius = PickUpRadius;
        recover = 10;
    }

    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            if (health.curHealth < health.maxHealth)
            {
                health.AddLife(recover);
                Destroy(this.gameObject);
            }
        }
    }
}
