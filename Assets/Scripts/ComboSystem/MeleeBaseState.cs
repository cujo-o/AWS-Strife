using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeBaseState : State
{
    // How long this state should be active for before moving on
    public float duration;
    // Cached animator component
    protected Animator animator;
    // bool to check whether or not the next attack in the sequence should be played or not
    protected bool shouldCombo;
    // The attack index in the sequence of attacks
    protected int attackIndex;



    // The cached hit collider component of this attack
    protected Collider2D hitCollider;
    // Cached already struck objects of said attack to avoid overlapping attacks on same target
  

    // Input buffer Timer
   // private float AttackPressedTimer = 0;

    public override void OnEnter(StateMachine _stateMachine)
    {
        base.OnEnter(_stateMachine);
        animator = GetComponent<Animator>();
       
      
       
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
       

      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shouldCombo = true;
        }

    }

    

    public override void OnExit()
    {
        base.OnExit();
    }

  

}