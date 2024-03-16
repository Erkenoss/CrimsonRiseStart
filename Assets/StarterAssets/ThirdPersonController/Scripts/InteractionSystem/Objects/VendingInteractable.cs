using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingInteractable : MonoBehaviour, IInteractable
{
    private GameObject can;
    public Inventory inventory;
    private bool isCan;

    private void Awake()
    {
        can = GameObject.FindGameObjectWithTag("Slot 2");
        isCan = true;
    }

    private void ToggleVending()
    {
        if (isCan)
        {
            inventory.slots[2] += 1;
            inventory.UpdateText(2, inventory.slots[2].ToString());
            Destroy(can);
        }
        isCan = false;
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleVending();
    }

    public string GetInteractText()
    {
        return "Buy Can";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
