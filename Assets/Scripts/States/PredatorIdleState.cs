using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorIdleState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        Debug.Log(predator.currentState);
        message = "I am hungry searching for food";

        predator.PredResetData();
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
                message = "Gotach! Prey, Chasing you";
            }
    }

    public override void OnCollisionEnter(PredatorStateManager predator, Collision collision)
    {
        GameObject other = collision.gameObject;

        if (other.GetComponent<Prey>())
        {
            predator.SwitchState(predator.predatorEvolveState);
            collision.gameObject.GetComponent<Prey>().ResetPosition();
            predator.predIncrementSize();
        }
    }
}
