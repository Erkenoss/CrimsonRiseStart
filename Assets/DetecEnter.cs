using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecEnter : MonoBehaviour
{
    public GameObject robot;
    private void OnTriggerEnter(Collider other)
    {
        robot.SetActive(true);
    }
}
