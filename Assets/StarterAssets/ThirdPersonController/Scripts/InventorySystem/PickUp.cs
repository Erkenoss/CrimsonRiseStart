using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider col)
    {
        switch(col.gameObject.tag)
        {
            case "Slot": //Energy Cell
            inventory.slots[0] += 1;
            inventory.UpdateText(0, inventory.slots[0].ToString());
            Destroy(col.gameObject);
            break;

            case "Slot 1": //Seringue
            inventory.slots[1] += 1;
            inventory.UpdateText(1, inventory.slots[1].ToString());
            Destroy(col.gameObject);
            break;

            case "Slot 2": //Can
            inventory.slots[2] += 1;
            inventory.UpdateText(2, inventory.slots[2].ToString());
            Destroy(col.gameObject);
            break;
        }
    }
}
