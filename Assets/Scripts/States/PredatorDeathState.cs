using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorDeathState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        message = "I am dieing help me!";
    }

    public override void OnTriggerStay(PredatorStateManager predator, Collider other)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(PredatorStateManager predator)
    {
        if (predator.iamBack)
        {
            message = " I will born again!!!!";
        }
    }
}
