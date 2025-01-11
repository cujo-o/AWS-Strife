using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveandRandomAttack : StateMachineBehaviour
{
    private int rand;
 private Transform player;

    public float firerate = 1f;
    private float nextfiretime;
    public float shootingrange;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
        rand = Random.Range(1, 5);
       
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        RandomAttack(animator);
      
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      
    }

    public void RandomAttack(Animator animator)
    {
        float distancefromplayer = Vector2.Distance(player.position, animator.transform.position);

        if (distancefromplayer <= shootingrange && nextfiretime < Time.time)
        {

            if (rand == 1)
            {
                animator.SetTrigger("range1");
            }
            else if (rand == 2)
            {
                animator.SetTrigger("range2");
            }
            else if (rand == 3)
            {
                animator.SetTrigger("melee1");
            }
            else
            {
                animator.SetTrigger("melee2");
            }
            // nextfiretime = Time.time + firerate;
        }
    }
   
}
