using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersAttacks : MonoBehaviour
{
    public StarterAssets.ThirdPersonController thirdPersonController;
    private void Awake()
    {
        thirdPersonController = GetComponent<StarterAssets.ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            if (thirdPersonController.checkAttack)
            {
                other.GetComponent<ElyHealth>().TakeDamage(20);
            }
        }
    }
}
