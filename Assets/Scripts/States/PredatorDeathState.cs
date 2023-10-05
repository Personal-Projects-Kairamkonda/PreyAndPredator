using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorDeathState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        Debug.Log(predator.currentState);

        message = "I have eaten a lot of pries and I became fat";

        //predator.predMovement.speed = 1f;
    }

    public override void UpdateState(PredatorStateManager predator)
    {
        
    }

    public override void OnTriggerStay(PredatorStateManager predator, Collider other)
    {
        GameObject prey = other.gameObject;

        if (prey.GetComponent<Prey>())
        {
            predator.predMovement.Move(other.transform.position);
            message = "Prey, Chasing you!, I can't move faster";
        }
    }

    public override void OnCollisionEnter(PredatorStateManager predator, Collision collision)
    {
        GameObject prey = collision.gameObject;

        if (prey.GetComponent<Prey>())
        {
            message = "I can't eat any more pries";
            collision.gameObject.GetComponent<Prey>().ResetPosition();
            predator.SwitchState(predator.predatorReproduceState);
        }
    }
}
