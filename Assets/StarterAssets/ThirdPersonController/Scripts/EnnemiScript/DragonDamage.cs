using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragonDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Health>().DamagePlayer(10);
        }
    }
}
