using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameplaySounds : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip menuSounds;
    public AudioClip gameplaySounds;

    public static GameplaySounds instance;

    void Awake()
    {
            GameplayMusic();
       

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
