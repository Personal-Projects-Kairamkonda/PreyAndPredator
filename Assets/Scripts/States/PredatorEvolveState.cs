using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorEvolveState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        message = "Yummy! I ate a prey";

    }

    public override void UpdateState(PredatorStateManager predator)
    {
         //message = " I am still hungry and I want to become fat";

        if (predator.predFatCount > 2)
        {
            predator.SwitchState(predator.predatorDeathState);
        }
    }

    public override void OnTriggerStay(PredatorStateManager predator, Collider other)
    {

    }


    public override void OnCollisionEnter(PredatorStateManager predator, Collision collision)
    {
        GameObject prey = collision.gameObject;

        if (prey.GetComponent<Prey>())
        {
            message = "Yummy! I ate a prey";
            predator.predFatCount++;
            collision.gameObject.GetComponent<Prey>().ResetPosition();
        }
    }
}
