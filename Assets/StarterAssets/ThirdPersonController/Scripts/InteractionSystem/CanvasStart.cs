using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStart : MonoBehaviour
{
    private GameObject textEnter;

    public void Start()
    {
        textEnter = GameObject.Find("CanvasStart");
        textEnter.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(textEnter);
        }
    }
}
