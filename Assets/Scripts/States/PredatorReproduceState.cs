using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorReproduceState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        Debug.Log(predator.currentState);

        message = "I am inevitable";
        predator.predMovement.speed = 0f;
    }

    public override void UpdateState(PredatorStateManager predator)
    {
        predator.predradius.triggerRadius -= 0.1f * Time.deltaTime;
        predator.predradius.DrawCircle(130, predator.predradius.triggerRadius);

        if(predator.predradius.triggerRadius<2)
        {
            predator.SwitchState(predator.predatorIdleState);
        }
    }

    public override void OnTriggerStay(PredatorStateManager predator,Collider other)
    {

    }

    public override void OnCollisionEnter(PredatorStateManager predator, Collision collision)
    {

    }
}
