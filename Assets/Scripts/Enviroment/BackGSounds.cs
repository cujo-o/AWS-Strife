using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class BackGSounds : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip menuSounds;
    public AudioClip gameplaySounds;

    public static BackGSounds instance;

    void Awake()
    {
      
       
          MenuMusic();
      
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

       
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            GameplayMusic();
        }

      //  if (SceneManager.GetActiveScene().buildIndex != 2 || SceneManager.GetActiveScene().buildIndex != 3 || SceneManager.GetActiveScene().buildIndex != 4)
        {
          //  MenuMusic();
        }

    }

    public void MenuMusic()
    {
        audioSource.clip = menuSounds;
        audioSource.Play();
    }

    public void GameplayMusic()
    {
        audioSource.clip = gameplaySounds;
        audioSource.Play();
    }
}
