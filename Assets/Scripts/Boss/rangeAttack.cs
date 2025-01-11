using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeAttack : MonoBehaviour
{
    public GameObject bossbullet;
    public GameObject bulletP1;
    public GameObject bulletP2;

    public float firerate = 1f;
    private float nextfiretime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextfiretime < Time.time)
        {
            nextfiretime = Time.time + firerate;
            fire();
        }
       
       
    }


    public void fire()
    {
        Instantiate(bossbullet, bulletP1.transform.position, Quaternion.identity);
        Instantiate(bossbullet, bulletP2.transform.position, Quaternion.identity);
    }
}
