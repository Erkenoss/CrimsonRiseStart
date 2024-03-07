using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialog : MonoBehaviour
{
    public GameObject chatBubble; // Référence à l'objet ChatBubble

    private void Start()
    {
        // Assurez-vous que la bulle de dialogue est désactivée au début
        if (chatBubble != null)
        {
            chatBubble.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Affiche la bulle de dialogue lorsque le joueur entre en collision avec le PNJ
            ShowDialogue();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Masque la bulle de dialogue lorsque le joueur quitte la collision avec le PNJ
            HideDialogue();
        }
    }

    private void ShowDialogue()
    {
        if (chatBubble != null)
        {
            chatBubble.SetActive(true);
        }
    }

    private void HideDialogue()
    {
        if (chatBubble != null)
        {
            chatBubble.SetActive(false);
        }
    }
}
