using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour, IInteractable
{

    [SerializeField] public string interactText;
    public GameObject chatBubble;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (chatBubble != null)
        {
            chatBubble.SetActive(false);
        }
    }

    public void Interact(Transform interactorTranform)
    {
        animator.SetTrigger("Talk");

        chatBubble.SetActive(true);
        StartCoroutine(DisableBubble());
    }

    private IEnumerator DisableBubble()
    {
        yield return new WaitForSeconds(6f);
        chatBubble.SetActive(false);
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
