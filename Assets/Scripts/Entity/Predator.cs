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

        SphereCollider trigger = gameObject.AddComponent<SphereCollider>();
        trigger.radius = 2f;
        trigger.isTrigger = true;
    }

   void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<Prey>())
        {
            Debug.Log(other.gameObject.name);
        }
    }

    void Evolve(float size,int speed)
    {
        transform.localScale = new Vector3(size, transform.localScale.y, size);
        predatorMovement.speed = speed;
    }
}
