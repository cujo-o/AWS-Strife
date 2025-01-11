using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprojectile : MonoBehaviour
{
    Transform target;
    public float speed;
    public float range = 200f;
    private GameObject targetEnemy;
    // Start is called before the first frame update
    void Start()
    {
        // target = GameObject.FindGameObjectWithTag("playerbullettarget").transform;
      // InvokeRepeating("UpdateTarget", 0f, 0.5f);
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTarget();
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);	
    }

   public void UpdateTarget ()
   {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag("playerbullettarget");
		
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;
		foreach (GameObject enemy in enemies)
		{
			float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

		if (nearestEnemy != null && shortestDistance <= range)
		{
			target = nearestEnemy.transform;
			//targetEnemy = GameObject.FindGameObjectWithTag("playerbullettarget");
		}
		else
		{
			target = null;
		}

	}
}
