using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3sounds : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] footsteps;
    private AudioClip footstepsclip;

    public AudioClip[] acidball;
    private AudioClip acidballclip;

   

    public AudioClip[] death;
    private AudioClip deathclip;

    public AudioClip[] damage;
    private AudioClip damageclip;

  
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
 
    public void acidballsound()
    {
        int index = Random.Range(0, acidball.Length);
        acidballclip = acidball[index];

        audioSource.clip = acidballclip;
        audioSource.Play();
    }
    public void damagesound()
    {
        int index = Random.Range(0, damage.Length);
       damageclip = damage[index];

        audioSource.clip = damageclip;
        audioSource.Play();
    }
    public void deathsound()
    {
        int index = Random.Range(0, death.Length);
      deathclip = death[index];

        audioSource.clip = deathclip;
        audioSource.Play();
    }
    public void footstepsound()
    {
        int index = Random.Range(0, footsteps.Length);
       footstepsclip = footsteps[index];

        audioSource.clip = footstepsclip;
        audioSource.Play();
    }

  
}
