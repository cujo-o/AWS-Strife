using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
   public PlayerHealth PH;
    public GameObject losepanel;
    // Start is called before the first frame update
    void Start()
    {
      //  PH = gameObject.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PH.CurrentHealth <= 0)
        {
            Invoke(nameof(youlost), 4);
        }
    }

    public void youlost()
    {
       losepanel.SetActive(true);
    }
}
