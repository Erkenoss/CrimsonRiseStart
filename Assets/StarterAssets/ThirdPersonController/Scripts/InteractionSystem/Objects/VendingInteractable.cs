using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingInteractable : MonoBehaviour, IInteractable
{
    private GameObject can;

    private void Awake()
    {
        can = GameObject.FindGameObjectWithTag("Can");
    }

    private void ToggleVending()
    {
        can.transform.parent = null;
        can.transform.position = new Vector3(can.transform.position.x, 0.2f, 24f);
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
