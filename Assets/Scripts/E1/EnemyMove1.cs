using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove1 : MonoBehaviour
{ public float speed; 
    public float firerate = 1f;
    private Transform player;   public bool isflipped = false;
    public float lineofsight; public Transform here; 
    private PlayerHealth playerhealth;
    public float shootingrange;
    public Transform attackpont;
    public float attackrange; 
    public LayerMask enemy;
    public Animator anim;
    private float nextfiretime;
   // private enemyhealth enemyhealth;

    private Rigidbody2D rb;
    public float delay = 0.15f;
    public float strength = 20f;

    public bool knocbackTaken = false;
    // Start is called before the first frame update
    void Start()
    {
         player = GameObject.FindGameObjectWithTag("player").transform;
        playerhealth = GetComponent<PlayerHealth>();
      //  enemyhealth = GameObject.FindAnyObjectByType<enemyhealth>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(knocbackTaken == true)
        {
           // StopAllCoroutines();
            Vector2 direction = (transform.position - player.position).normalized;
            rb.AddForce(direction * strength);
           // StopAllCoroutines();
            StartCoroutine(Reset());
        }
        else
        {
            float distancefromplayer = Vector2.Distance(player.position, transform.position);
            if (distancefromplayer < lineofsight && distancefromplayer > shootingrange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
            }
            else if (distancefromplayer <= shootingrange && nextfiretime < Time.time)
            {
                anim.SetTrigger("attack");
                nextfiretime = Time.time + firerate;
            }

            flip();
        }
    }


    public IEnumerator Reset()
    {
        yield return new WaitForSeconds(delay);
        rb.velocity = Vector3.zero;
        knocbackTaken = false;
    }

    public  void attack() {
        
        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackpont.position, attackrange, enemy);
        for (int i = 0; i <hitenemies.Length   ; i++)
        {
           hitenemies[i].GetComponent<PlayerHealth>().TakeDamage(5.0f);
        }
    }


    public void flip()
    {
         Vector3 Scale = transform.localScale;
        Scale.z *= -1f;
        if ( transform.position.x < player.position.x && isflipped)
        {
            transform.localScale = Scale;
            transform.Rotate(0, 180f, 0);
            isflipped = false;
        }
        else if (transform.position.x > player.position.x && !isflipped)
        {
            transform.localScale = Scale;
            transform.Rotate(0, 180f, 0);
            isflipped = true;
        }
        transform.localScale = Scale;

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(here.position, lineofsight); 
        Gizmos.DrawWireSphere(here.position, attackrange);
    }
}
