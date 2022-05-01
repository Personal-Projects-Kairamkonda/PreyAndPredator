using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : MonoBehaviour
{
    private ObjectMovement predatorMovement;

    void Awake()
    {
        predatorMovement = this.GetComponent<ObjectMovement>();
    }
    void Start()
    {
        predatorMovement.speed = 3f;

        SphereCollider trigger = gameObject.AddComponent<SphereCollider>();
        trigger.radius = 2f;
        trigger.isTrigger = true;
    }

   void OnTriggerStay(Collider other)
    {
       if (other.GetComponent<Prey>())
       {
            predatorMovement.targetPosition = other.transform.position;
            Evolve(1.3f, 1);
       }
    }

    void Evolve(float size,int speed)
    {
        transform.localScale = new Vector3(size, transform.localScale.y, size);
        predatorMovement.speed = speed;
    }
}
