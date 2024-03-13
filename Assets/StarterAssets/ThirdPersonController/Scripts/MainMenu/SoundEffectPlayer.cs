using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2;

    public void ButtonStart()
    {
        src.clip = sfx1;
        src.Play();
    }

    public void ButtonQuit()
    {
        src.clip = sfx2;
        src.Play();
    }
}
