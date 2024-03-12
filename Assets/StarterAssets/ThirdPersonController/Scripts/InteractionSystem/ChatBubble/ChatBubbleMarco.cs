using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubbleMarco : MonoBehaviour
{
    private SpriteRenderer backGroundSpriteRenderer;
    private SpriteRenderer iconSpriteRenderer;
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        backGroundSpriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
        iconSpriteRenderer = transform.Find("Icon").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    private void Start() {
        Setup("Could you help me with that person?!");
    }
    private void Setup(string text)
    {
        textMeshPro.SetText(text);
    }
}
