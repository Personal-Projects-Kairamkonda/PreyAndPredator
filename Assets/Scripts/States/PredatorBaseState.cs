using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PredatorBaseState 
{
    public string message;

    public abstract void EnterState(PredatorStateManager predator);

    public abstract void UpdateState(PredatorStateManager predator);

    public abstract void OnTriggerStay(PredatorStateManager predator, Collider other);

    public abstract void OnCollisionEnter(PredatorStateManager predator, Collision collision);
}
