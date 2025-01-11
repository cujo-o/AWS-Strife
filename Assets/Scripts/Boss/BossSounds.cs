using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSounds : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] footsteps;
    private AudioClip footstepsclip;

    public AudioClip[] electball;
    private AudioClip electballclip;

   


    public AudioClip[] death;
    private AudioClip deathclip;

    public AudioClip[] damage;
    private AudioClip damageclip;

    public AudioClip[] slice;
    private AudioClip sliceclip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
 

    public void slicesound()
    {
        int index = Random.Range(0, slice.Length);
        sliceclip = slice[index];

        audioSource.clip = sliceclip;
        audioSource.Play();
    }
    public void electballsound()
    {
        int index = Random.Range(0, electball.Length);
       electballclip = electball[index];

        audioSource.clip = electballclip;
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
