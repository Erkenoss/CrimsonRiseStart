using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : MonoBehaviour
{
    private Inventory inventory;
    private Health health;

    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    }
    public void Click()
    {
        //Index of my slot
        int index = transform.parent.GetSiblingIndex();
        if (inventory.slots[index] > 0)
        {
            inventory.slots[index] -= 1;
            inventory.UpdateText(index, inventory.slots[index].ToString());

            switch(index)
            {
                case 2:
                health.AddLife(20);
                break;
            }
        }
    }
}
