using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    private bool activate = false;
    public GameObject panel;
    public int[] slots;

    // Start is called before the first frame update
    void Start()
    {
            GetComponent<Canvas>().enabled = activate;
            panel = transform.GetChild(0).gameObject;
            slots = new int[panel.transform.childCount];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activate = !activate;
            GetComponent<Canvas>().enabled = activate;
        }
    }

    public void UpdateText(int index, string text)
    {
        TextMeshProUGUI textComponent = panel.transform.GetChild(index).GetChild(1).GetComponent<TextMeshProUGUI>();
        textComponent.text = text;
    }
}
