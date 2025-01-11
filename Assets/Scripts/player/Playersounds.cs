using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playersounds : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] footsteps;
    private AudioClip footstepsclip;

    public AudioClip[] fireball;
    private AudioClip fireballclip;

    public AudioClip[] dash;
    private AudioClip dashclip;

    public AudioClip[] death1;
    private AudioClip death1clip;


    public AudioClip[] death;
    private AudioClip deathclip;

    public AudioClip[] damage;
    private AudioClip damageclip;

    public AudioClip[] meleeAT;
    private AudioClip meleeATclip;
       
        public AudioClip[] meleeAT2;
    private AudioClip meleeAT2clip;

    public AudioClip[] meleeAT3;
    private AudioClip meleeAT3clip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
 

    public void meleeATsound()
    {
        int index = Random.Range(0, meleeAT.Length);
        meleeATclip = meleeAT[index];

        audioSource.clip = meleeATclip;
        audioSource.Play();
    }

    public void meleeATsound2()
    {
        int index = Random.Range(0, meleeAT2.Length);
        meleeAT2clip = meleeAT2[index];

        audioSource.clip = meleeAT2clip;
        audioSource.Play();
    }
    public void meleeATsound3()
    {
        int index = Random.Range(0, meleeAT3.Length);
        meleeAT3clip = meleeAT3[index];

        audioSource.clip = meleeAT3clip;
        audioSource.Play();
    }


    public void fireballsound()
    {
        int index = Random.Range(0, fireball.Length);
        fireballclip = fireball[index];

        audioSource.clip = fireballclip;
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
    public void deathsound1()
    {
        int index = Random.Range(0, death1.Length);
        death1clip = death1[index];

        audioSource.clip = death1clip;
        audioSource.Play();
    }
    public void footstepsound()
    {
        int index = Random.Range(0, footsteps.Length);
       footstepsclip = footsteps[index];

        audioSource.clip = footstepsclip;
        audioSource.Play();
    }

    public void dashsound()
    {
        int index = Random.Range(0, dash.Length);
        dashclip = dash[index];

        audioSource.clip = dashclip;
        audioSource.Play();
    }

}
