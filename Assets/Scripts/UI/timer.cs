using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{ 
    public Animator anim;
    public float elapsedtime; 
    public enemyspawner enemyspawner;
   // public TextMeshProUGUI sceneText;
    void Start()
    {
      //  enemyspawner = GetComponent<enemyspawner>();
    }

    
    void Update()
    {
        GameObject[] enemynumber = GameObject.FindGameObjectsWithTag("enemy"); 
      

        int enumb = enemynumber.Length;
        elapsedtime -= Time.deltaTime;
        if (elapsedtime<=0)
        {
            enemyspawner.canspawn=false;
        }
        if (enumb<=0)
        {
            StartCoroutine(finised());
        } 
    }

    IEnumerator finised()
    {
       // sceneText.text = SceneManager.GetActiveScene().name;
        anim.SetTrigger("end");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        anim.SetTrigger("start");
    }
        
}
