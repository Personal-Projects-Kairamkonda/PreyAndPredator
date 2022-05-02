using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorReproduceState : PredatorBaseState
{
    public override void EnterState(PredatorStateManager predator)
    {
        message = "I am inevitable";
    }


    public override void UpdateState(PredatorStateManager predator)
    {
        message = "I am hunting again Baby!";
    }

    public override void OnTriggerStay(PredatorStateManager predator,Collider other)
    {

    }
}
