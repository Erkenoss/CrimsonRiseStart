using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShowAndHide : MonoBehaviour
{
    public bool activeInventory = true;
    public GameObject inventoryContainer;
    private List<GameObject> inventoryChildren = new List<GameObject>();

    private void Start() {
        for (int i = 0; i < inventoryContainer.transform.childCount; i++)
        {
            GameObject inventoryChild = inventoryContainer.transform.GetChild(i).gameObject;

            inventoryChildren.Add(inventoryChild);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            Debug.Log(activeInventory);

            foreach (GameObject inventoryChild in inventoryChildren)
            {
                inventoryChild.SetActive(activeInventory);
            }
        }
    }
}

