using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
   
    public float speed;
    public Animator animator;
    private Transform player;
    public float lineofsight;
    public Transform here;
    public float firerate = 1f;
    private float nextfiretime;
    public float shootingrange;
    public bool isflipped = false;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        float distancefromplayer = Vector2.Distance(player.position, transform.position);
        if (distancefromplayer < lineofsight && distancefromplayer > shootingrange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
       
        flip();
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
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(here.position, lineofsight);
        Gizmos.DrawWireSphere(here.position, shootingrange);
    }
}


