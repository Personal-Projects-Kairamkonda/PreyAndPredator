using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : MonoBehaviour
{
    private ObjectMovement predMovement;
    private Radius predRadius;
    public GameObject predSize;

    void Awake()
    {
        predMovement = this.GetComponent<ObjectMovement>();
        predRadius = this.GetComponent<Radius>();
    }

    void Start()
    {
        //predMovement.speed = 3f;
    }

    /*
    void OnTriggerStay(Collider other)
    {
        /*
        Prey prey = other.GetComponent<Prey>();

        if (prey)
        {
            predMovement.Move(other.transform.position);
        }
        */
        
        /* This logic makes the predator messy with position when both are in the same trigger.

        Predator predator = other.GetComponent<Predator>();
        if(predator)
        {
            predatorMovement.targetPosition = predatorMovement.getRandomPosition();
            predatorMovement.Move(predatorMovement.targetPosition);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        Prey prey = collision.gameObject.GetComponent<Prey>();

        if (prey)
        {
            prey.ResetPosition();
        }
    }

    */

}
