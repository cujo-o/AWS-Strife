using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject PauseButton;
    public void Pause()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
        PauseButton.SetActive(false);
    }

   
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseButton.SetActive(true);
    }

    public void Home()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
