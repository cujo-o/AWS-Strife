using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmeleeAttack : MonoBehaviour
{
   public PlayerHealth ph;
    public float bossmeleeDamge;
    // Start is called before the first frame update
    void Start()
    {
       // ph = gameObject.GetComponent<PlayerHealth>();
    }

  

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="player")
        {
            ph.GetComponent<PlayerHealth>().TakeDamage(bossmeleeDamge);
        }

    }
}
