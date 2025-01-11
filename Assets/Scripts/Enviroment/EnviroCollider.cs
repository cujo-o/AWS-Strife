using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviroCollider : MonoBehaviour
{
  

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            //where youll play the players sound
        }
    }
}
