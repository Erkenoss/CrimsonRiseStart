// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Cinemachine;
// using TMPro;

// public class WallInteractable : MonoBehaviour, IInteractable
// {
//     public CinemachineVirtualCamera mainCamera;
//     public CinemachineVirtualCamera windowCamera;
//     public TextMeshPro textMain;
//     public TextMeshPro textWindow;
//     public bool windowMode;


//     private void Start()
//     {
//         // textMain.gameObject.SetActive(false);
//         textWindow.gameObject.SetActive(false);

//         mainCamera.enabled = !windowMode;
//         windowCamera.enabled = windowMode;
//     }

//     private IEnumerator DeleteText(TextMeshPro text)
//     {
//         yield return new WaitForSeconds(5);
//         Destroy(text.gameObject);
//     }
//     private void ToggleWindow()
//     {
//         windowMode = !windowMode;
//         if (windowMode)
//         {
//             textMain.gameObject.SetActive(windowMode);
//             StartCoroutine(DeleteText(textMain));
//         }
//         else
//         {
//             textWindow.gameObject.SetActive(!windowMode);
//             StartCoroutine(DeleteText(textWindow));
//         }

//         mainCamera.enabled = !windowMode;
//         windowCamera.enabled = windowMode;
//     }

//     public void Interact(Transform interactorTransform)
//     {
//         ToggleWindow();
//     }

//     public string GetInteractText()
//     {
//         return "Check Outside";
//     }

//     public Transform GetTransform()
//     {
//         return transform;
//     }
// }
