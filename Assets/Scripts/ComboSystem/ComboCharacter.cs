using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboCharacter : MonoBehaviour
{

    private StateMachine meleeStateMachine;

   
    // Start is called before the first frame update
    void Start()
    {
        meleeStateMachine = GetComponent<StateMachine>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) && meleeStateMachine.CurrentState.GetType() == typeof(IdleCombatState)) 
            || (Input.GetKeyDown(KeyCode.Mouse0) && meleeStateMachine.CurrentState.GetType() == typeof(IdleCombatState)))
        {
            meleeStateMachine.SetNextState(new GroundEntryState());
        }
    }
}