using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class WallInteractable : MonoBehaviour, IInteractable
{
    public CinemachineVirtualCamera mainCamera;
    public CinemachineVirtualCamera windowCamera;
    public GameObject canvasCam;
    public bool windowMode;


    private void Start()
    {
        mainCamera.enabled = !windowMode;
        windowCamera.enabled = windowMode;
        canvasCam.transform.GetChild(1).gameObject.SetActive(false);
        canvasCam.transform.GetChild(0).gameObject.SetActive(false);
    }

    private void ToggleWindow()
    {
        windowMode = !windowMode;

        if (!windowMode)
        {
            canvasCam.transform.GetChild(1).gameObject.SetActive(false);
            canvasCam.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            canvasCam.transform.GetChild(0).gameObject.SetActive(false);
            canvasCam.transform.GetChild(1).gameObject.SetActive(true);
        }

        mainCamera.enabled = !windowMode;
        windowCamera.enabled = windowMode;
        StartCoroutine(disableText());
    }

    public IEnumerator disableText()
    {
        yield return new WaitForSeconds(5);
        if (!windowMode)
        {
            canvasCam.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            canvasCam.transform.GetChild(1).gameObject.SetActive(false);
        }
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleWindow();
    }

    public string GetInteractText()
    {
        return "Check Outside";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
