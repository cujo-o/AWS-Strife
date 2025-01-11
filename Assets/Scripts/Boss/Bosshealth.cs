using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bosshealth : MonoBehaviour
{
    public Animator anim;
    public float Health = 100.0f;  //Health of the player. Just for stating sake and easy modification in the editor
    public float CurrentHealth;
    public Slider BossBar;
    // Start is called before the first frame update
    void Start()
    {
        
        CurrentHealth = Health;
       BossBar.value = CurrentHealth;
    }

    void Update()
    {
    }

    //This function is for the player to detect damage
    public void TakeDamage(float damage)
    {
          CurrentHealth -= damage; //Reduces the current health of the player
       // anim.SetTrigger("damage");
        BossBar.value = CurrentHealth;
        if (CurrentHealth <= 0)
        {
            Death();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("playerbullet"))
        {
            TakeDamage(10f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("scythe"))
        {
            TakeDamage(20f);
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
