// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class SentryDialogue : MonoBehaviour
// {
//     public GameObject dial;

//     // Update is called once per frame
//     private void OnTriggerEnter(Collider other)
//     {
//         dial.SetActive(true);
//         dial.transform.GetChild(0).gameObject.SetActive(true);
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         dial.SetActive(false);
//     }

//     public void SetActiveChildOne()
//     {
//         dial.transform.GetChild(0).gameObject.SetActive(false);
//         dial.transform.GetChild(1).gameObject.SetActive(true);
//     }

//     public void SetActiveChildtwo()
//     {
//         dial.transform.GetChild(1).gameObject.SetActive(false);
//         dial.transform.GetChild(2).gameObject.SetActive(true);
//     }
//     public void SetActiveChildThree()
//     {
//         dial.transform.GetChild(2).gameObject.SetActive(false);
//         dial.transform.GetChild(3).gameObject.SetActive(true);
//     }

//     public void DestroySentry()
//     {
//         dial.transform.GetChild(3).gameObject.SetActive(false);
//         StartCoroutine(Next());
//     }

//     private IEnumerator Next()
//     {
//         yield return new WaitForSeconds(3);
//         GameObject sentry = GameObject.Find("Sentry");
//         Destroy(sentry);
//     }
// }
