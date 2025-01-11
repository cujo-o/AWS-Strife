using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyprojectile : MonoBehaviour
{ GameObject target;
    public float speed;
    private PlayerHealth playerhealth;
    Rigidbody2D enemyrb;
    // Start is called before the first frame update
    void Start()
    {
        playerhealth = GetComponent<PlayerHealth>();
        enemyrb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("target");
        Vector2 movedir = (target.transform.position - transform.position).normalized * speed;
        enemyrb.velocity = new Vector2(movedir.x, movedir.y);
       Destroy(this.gameObject, 2); }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="player")
        {
            playerhealth.GetComponent<PlayerHealth>().TakeDamage(21.0f);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag    =="player")
        {
         playerhealth.GetComponent<PlayerHealth>().TakeDamage(21.0f);
        }   
    }
}
