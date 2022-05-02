using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorIdleState : PredatorBaseState
{

    public override void EnterState(PredatorStateManager predator)
    {
        message = "I am in idle state, started moving";
    }

    public override void UpdateState(PredatorStateManager predator)
    {
        if (predator.collidedWithPrey)
        {
            message = "I am hungry searching for food";
            predator.SwitchState(predator.predatorEvolveState);
        }
    }

    public override void OnTriggerStay(PredatorStateManager predator, Collider other)
    {
        Prey prey = other.GetComponent<Prey>();

        if (prey)
        {
            predator.predMovement.Move(other.transform.position);
        }
    }

}
