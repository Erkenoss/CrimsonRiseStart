using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStart : MonoBehaviour
{
    private GameObject textEnter;

    public void Start()
    {
        textEnter = GameObject.FindGameObjectWithTag("StartText");
        textEnter.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            textEnter.SetActive(false);
        }
    }
}
