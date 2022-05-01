using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : MonoBehaviour
{
    private ObjectMovement predatorMovement;

    void Awake()
    {
        predatorMovement = this.GetComponent<ObjectMovement>();

        SphereCollider triggerCollider = gameObject.AddComponent<SphereCollider>();
        triggerCollider.radius = this.GetComponent<Radius>().triggerRadius;
        triggerCollider.isTrigger = true;
    }

    void Start()
    {
        predatorMovement.speed = 3f;
    }

    void OnTriggerStay(Collider other)
    {
        Prey prey = other.GetComponent<Prey>();
        Predator predator = other.GetComponent<Predator>();

        if (prey)
        {
            //predatorMovement.targetPosition = other.transform.position;
            predatorMovement.Move(other.transform.position);
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
        predatorMovement.speed = speed;
    }
}
