using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    private Animator animator;
    private bool isOpen;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ToggleDoor()
    {
        isOpen = !isOpen;
        animator.SetBool("IsOpen", isOpen);
        StartCoroutine(After());
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleDoor();
    }

    public string GetInteractText()
    {
        return "Open/Close Door";
    }

    public Transform GetTransform()
    {
        return transform;
    }

    private IEnumerator After()
    {
        yield return new WaitForSeconds(5);
        animator.SetBool("IsOpen", false);
    }
}
