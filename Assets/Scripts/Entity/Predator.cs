using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : MonoBehaviour
{
    private ObjectMovement predMovement;
    private Radius predRadius;

    void Awake()
    {
        predMovement = this.GetComponent<ObjectMovement>();
        predRadius = this.GetComponent<Radius>();

        SphereCollider triggerCollider = gameObject.AddComponent<SphereCollider>();
        triggerCollider.radius = predRadius.triggerRadius;
        triggerCollider.isTrigger = true;
    }

    void Start()
    {
        predMovement.speed = 3f;
    }

    void OnTriggerStay(Collider other)
    {
        Prey prey = other.GetComponent<Prey>();
        Predator predator = other.GetComponent<Predator>();

        if (prey)
        {
            //predMovement.speed = predMovement.speed / 2;
            predMovement.Move(other.transform.position);
            predRadius.circleRenderer.material.color = Color.red;
        }
        else
        {
            predRadius.circleRenderer.material.color = Color.black;
            predMovement.speed = 3f;
        }

        /* This logic makes the predator messy with position when both are in the same trigger.
        if(predator)
        {
            predatorMovement.targetPosition = predatorMovement.getRandomPosition();
            predatorMovement.Move(predatorMovement.targetPosition);
        }
        */
    }

    
    void OnCollisionEnter(Collision collision)
    {
        Prey prey = collision.gameObject.GetComponent<Prey>();

        if (prey)
        {
            prey.ResetPosition();
        }
    }

    

    void Evolve(float size,int speed)
    {
        transform.localScale = new Vector3(size, transform.localScale.y, size);
        predMovement.speed = speed;
    }
}
