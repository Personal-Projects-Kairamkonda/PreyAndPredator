using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorEvolveState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        Debug.Log(predator.currentState);

        message = "Yummy! I ate a prey";
    }

    public override void UpdateState(PredatorStateManager predator)
    {
        if (predator.predFatCount > 2)
        {
            predator.SwitchState(predator.predatorDeathState);
        }
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
        GameObject prey = collision.gameObject;

        if (prey.GetComponent<Prey>())
        {
            message = "Wow! I ate an another prey";
            predator.predFatCount++;
            collision.gameObject.GetComponent<Prey>().ResetPosition();
            predator.predIncrementSize();
        }
    }
}
