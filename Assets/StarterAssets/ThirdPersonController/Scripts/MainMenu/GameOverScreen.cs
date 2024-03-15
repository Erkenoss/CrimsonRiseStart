using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameOverScreen : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2;

    public void Setup()
    {
        gameObject.SetActive(true);
    }
    public void RestartButton()
    {
        StartCoroutine(LoadScene());
    }
    public void QuitButton()
    {
        SceneManager.LoadScene(0);
    }

    private IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadSceneAsync(1);
    }
    public void ButtonRestart()
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
