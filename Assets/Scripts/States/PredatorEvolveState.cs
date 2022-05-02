using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorEvolveState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        message="I have eaten a prey and  I am growing";
    }

    public override void UpdateState(PredatorStateManager predator)
    {
        if (predator.iamFat)
        {
            message = " I am still hungry and I want to become fat";
            predator.SwitchState(predator.predatorDeathState);
        }
    }

    public override void OnTriggerStay(PredatorStateManager predator, Collider other)
    {

    }

}
