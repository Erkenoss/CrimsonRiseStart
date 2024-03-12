using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorInteractable : MonoBehaviour, IInteractable
{
    public Vector3 rotation;
    public float speed;
    private Quaternion targetRotation;
    private ParticleSystem spark;

    private void Start()
    {
        targetRotation = transform.rotation;
        spark = GetComponent<ParticleSystem>();
    }

    private void ToggleMotor()
    {
        targetRotation *= Quaternion.Euler(rotation);
        spark.Play();
    }

    private void Update()
    {
        spark.Stop();
        //Start to go in direction of the target (interpolation) given in the editor on the x axes
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed * Time.deltaTime);
        if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
        {
            targetRotation = transform.rotation;
        }
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleMotor();
    }

    public string GetInteractText()
    {
        return "Touch Motor";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
