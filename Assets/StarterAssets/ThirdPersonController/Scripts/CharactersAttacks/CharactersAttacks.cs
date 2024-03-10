using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersAttacks : MonoBehaviour
{
    public List<Collider> characterCollider = new List<Collider>();

    private void Awake()
    {
        SetCollider();
    }

    private void SetCollider ()
    {
        Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();

        foreach(Collider col in colliders)
        {
            if (col.gameObject != this.gameObject)
            {
                col.isTrigger = true;
                characterCollider.Add(col);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<ElyHealth>().TakeDamage(20);
        }
    }
}
