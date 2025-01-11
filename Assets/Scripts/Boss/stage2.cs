using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2 : StateMachineBehaviour
{
    Bosshealth BH;
  
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        BH = animator.GetComponent<Bosshealth>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       

        if (BH.CurrentHealth <= 500f)
        {
            animator.SetTrigger("stage2");
            Debug.Log("stage2 works");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

}