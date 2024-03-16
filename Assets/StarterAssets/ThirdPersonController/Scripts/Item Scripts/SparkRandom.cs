using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkRandom : MonoBehaviour
{
    private ParticleSystem spark;
    void Start()
    {
        spark = GetComponent<ParticleSystem>();
        StartCoroutine(ParticleSystem());
    }

    private IEnumerator ParticleSystem()
    {
        while(true)
        {
            int delay = Random.Range(1, 4);

            yield return new WaitForSeconds(delay);

            spark.Play();
        }
    }
}
