using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Animator anim;
    private Slider PlayerHealthBar;
    
    public float Health = 100.0f;  
    public float CurrentHealth; 
                              
    public float shakeIntensity;
    public float shakeTime;

    public float healthTimer = 5f;
    private screenShake screenShake;

    void Start()
    {
        PlayerHealthBar = GameObject.FindGameObjectWithTag("PHB").GetComponent<Slider>();
        screenShake = GameObject.FindAnyObjectByType<screenShake>();
        CurrentHealth = Health;
        PlayerHealthBar.value = CurrentHealth;
    }

    void Update()
    {
       
        if (CurrentHealth<Health)
        {
            healthTimer -= Time.deltaTime;
            if (healthTimer <= 0)
            {
                CurrentHealth += 5f;
                healthTimer = 5f;
                PlayerHealthBar.value = CurrentHealth;
                PlayerHealthBar.value = CurrentHealth;
            }
        }  

    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            TakeDamage(5f);
            Destroy(collision.gameObject); 
        }
    }

    //This function is for the player to detect damage
    public void TakeDamage(float damage)
    {
        //  PlayerHit.Play(); //If there's a Hit audio, play it. Else just comment this code out to prevent compile errors
        CurrentHealth -= damage; //Reduces the current health of the player
        anim.SetTrigger("damage");
        PlayerHealthBar.value = CurrentHealth;
        screenShake.shakeCamera(shakeIntensity, shakeTime);
        if (CurrentHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        anim.SetTrigger("die");
    }

    public void Death2()
    {
        Destroy(gameObject);
    }
}