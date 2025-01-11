using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{   
    public GameObject[] enemyies;
    public float spawnrate;
    public bool canspawn = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnenemy());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private IEnumerator spawnenemy()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnrate);
        while (canspawn)
        {
            yield return wait;
            int rand = Random.Range(0, enemyies.Length);
            GameObject enemytospawn = enemyies[rand];

            Instantiate(enemytospawn, transform.position, Quaternion.identity); 
           
        }

    }
	public  void win()
    {

	}
}
