using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private float timer;
    private float normalRange;
    private float fRange;
    private void Awake() {
        normalRange = 5.0f;
        fRange =  2.5f;
    }
    private IEnumerator Start()
    {
        while(true)
        {
            GetComponent<Light>().range = (GetComponent<Light>().range == fRange) ? normalRange : fRange;

            yield return new WaitForSeconds(timer);
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
    void Update()
    {
        timer = Random.Range(0.5f, 1.0f);
    }
}
