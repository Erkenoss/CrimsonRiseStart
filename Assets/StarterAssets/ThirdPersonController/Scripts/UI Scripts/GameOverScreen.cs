using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
        StartCoroutine("Wait");
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Environment");
    }
    public void QuitButton()
    {
        SceneManager.LoadScene("Main menu");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
