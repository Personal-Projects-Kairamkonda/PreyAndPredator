using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorDeathState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        Debug.Log(predator.currentState);

        //message = "I am dieing help me!";
        message = "I have eaten a lot of pries and I became fat";

        predator.predMovement.speed = 1f;
    }


    public override void UpdateState(PredatorStateManager predator)
    {
        if (predator.iamBack)
        {
            message = " I will born again!!!!";
        }
    }

    public override void OnTriggerStay(PredatorStateManager predator, Collider other)
    {
        GameObject prey = other.gameObject;

        if (prey.GetComponent<Prey>())
        {
            predator.predMovement.Move(other.transform.position);
            message = "Prey, Chasing you!";
        }
    }


    public override void OnCollisionEnter(PredatorStateManager predator, Collision collision)
    {
        GameObject prey = collision.gameObject;

        if (prey.GetComponent<Prey>())
        {
            message = "I can't eat more pries";
            collision.gameObject.GetComponent<Prey>().ResetPosition();
        }
    }
}
