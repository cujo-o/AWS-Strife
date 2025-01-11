using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosdeath : MonoBehaviour
{
    public Bosshealth BH;
    public GameObject winpanel;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (BH.CurrentHealth<=0)
        {
            Invoke(nameof(youwon), 4);
        }
    }

    public void youwon()
    {
        winpanel.SetActive(true);
    }
}
