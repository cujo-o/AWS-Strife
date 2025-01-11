using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletparent;
    public float firerate = 1f;
    private float nextfiretime;
    public float attackrate;
    float nextattacktime;
    public float Speed;
    public float dashcooldown;
    public bool isFacingRight;
    private float activemovespeed;
    public Rigidbody2D rb;
    public Animator anim;
    public ParticleSystem dust;
    private float dashcounter; 
   
    public float dashingSpeed;
    public float dashinglenght;
    private float dashingCoolcounter;    
    private Vector2 moveinput;
    void Update()
    {
        moveinput.x = Input.GetAxisRaw("Horizontal");
        moveinput.y = Input.GetAxisRaw("Vertical");
        moveinput.Normalize();

        rb.velocity = moveinput *activemovespeed;
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (dashcounter<=0&&dashingCoolcounter<=0)
            {
                activemovespeed = dashingSpeed;
                dashcounter = dashinglenght; 
                {
                    anim.SetTrigger("dash");
                }
            }
        }
      
        if (dashcounter>0)
        {
            dashcounter -= Time.deltaTime;
            if (dashcounter<=0)
            {
                activemovespeed = Speed;
                dashingCoolcounter = dashcooldown;
            }
        }
        if (dashingCoolcounter>0)
        {
            dashingCoolcounter -= Time.deltaTime;
        }
        if (moveinput.x == 0 && moveinput.y == 0) { 

                anim.SetBool("isrunning", false);
        }
        else
        {
            anim.SetBool("isrunning", true);
        }
        Flip();
        if (nextfiretime < Time.time)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                anim.SetTrigger("fire");
                nextfiretime = Time.time + firerate;
            }
        }
    }



    void Start()
    {
        activemovespeed = Speed;  
    }

    public void fire()
    {
        Instantiate(bullet, bulletparent.transform.position, Quaternion.identity);
        nextfiretime = Time.time + firerate;
    }


    void Flip()
    {
        if (isFacingRight && moveinput.x < 0f || !isFacingRight && moveinput.x > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
    }
    public void dustt()
    {
        dust.Play(true);
      
    }
}
