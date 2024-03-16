using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentryInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] public string interactText;
    public GameObject dial;
    public List<Transform> dialChild = new List<Transform>();
    private Transform player;

    private void Start()
    {
        if (dial != null)
        {
            foreach (Transform child in dial.transform)
            {
                dialChild.Add(child);
                child.gameObject.SetActive(false);
            }
        }
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.position, gameObject.transform.position);
        if (Input.GetKeyDown(KeyCode.E) && distance < 4)
        {
            if (dialChild.Count > 0 && !dialChild[0].gameObject.activeSelf)
            {
                dialChild[0].gameObject.SetActive(true);
            }
            else if(dialChild.Count > 0 && dialChild[0].gameObject.activeSelf)
            {
                dialChild[0].gameObject.SetActive(false);
                if (dialChild.Count > 1)
                {
                    dialChild[1].gameObject.SetActive(true);
                }
                dialChild.RemoveAt(0);
            }
        }
        if (dialChild.Count == 0)
        {
            StartCoroutine(SentryLeave());
        }
    }

    private IEnumerator SentryLeave()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
    public void Interact(Transform interactorTranform)
    {
        dial.SetActive(true);
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
