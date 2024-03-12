using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComputerInteractable : MonoBehaviour, IInteractable
{
    private GameObject screen;
    private GameObject screen2;

    private void Awake()
    {
        screen = GameObject.FindGameObjectWithTag("Screen");
        screen2 = GameObject.FindGameObjectWithTag("Screen2");
        screen.SetActive(false);
        screen2.SetActive(false);
    }
    public void ToggleComputer()
    {
        screen.SetActive(true);
        screen2.SetActive(true);
        StartCoroutine(After());
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleComputer();
    }

    public string GetInteractText()
    {
        return "Computer";
    }

    public Transform GetTransform()
    {
        return transform;
    }

    private IEnumerator After()
    {
        yield return new WaitForSeconds(5);
        screen.SetActive(false);
        screen2.SetActive(false);
    }
}
