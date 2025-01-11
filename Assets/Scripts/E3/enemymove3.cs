using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove3 : MonoBehaviour
{
    public float speed;
  
    private Transform player; 
    public float shootingrange;
    public Transform here;
    public float lineofsight; 
    public GameObject bullet;
    public GameObject bulletparent;
    public float firerate = 1f;  
    private float nextfiretime;  
    public Animator Anim;
    public bool isflipped = false;


    private Rigidbody2D rb;
    public float delay = 0.15f;
    public float strength = 200f;
   

    public bool knocbackTaken = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (knocbackTaken == true)
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
                Anim.SetTrigger("fire");
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
    public  void    fire()
	{
        Instantiate(bullet, bulletparent.transform.position, Quaternion.identity);
    

	}
   public void flip()
        {
            Vector3 Scale = transform.localScale;
            Scale.z *= -1f;
            if (transform.position.x < player.position.x && isflipped)
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
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(here.position, lineofsight);
        Gizmos.DrawWireSphere(here.position,shootingrange);
    }
}
