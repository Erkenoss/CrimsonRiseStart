using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorInteractable : MonoBehaviour, IInteractable
{
    public void TurnLightOnOff()
    {
        Light[] lights = GetComponentsInChildren<Light>();

        foreach(Light light in lights)
        {
            light.enabled = !light.enabled;
        }
    }
    public void Interact(Transform interactorTransform)
    {
        TurnLightOnOff();
    }

    public string GetInteractText()
    {
        return "Turn light On/Off";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
