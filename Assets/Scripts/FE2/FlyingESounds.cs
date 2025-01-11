using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingESounds : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] wingflp;
    private AudioClip wingflpclip;

  

    public AudioClip[] death;
    private AudioClip deathclip;

    public AudioClip[] damage;
    private AudioClip damageclip;

    public AudioClip[] explode;
    private AudioClip explodeclip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
 

    public void explodesound()
    {
        int index = Random.Range(0, explode.Length);
        explodeclip = explode[index];

        audioSource.clip = explodeclip;
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
    public void wingfalpsound()
    {
        int index = Random.Range(0, wingflp.Length);
        wingflpclip = wingflp[index];

        audioSource.clip = wingflpclip;
        audioSource.Play();
    }

  
}
