using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : MonoBehaviour
{
    private ObjectMovement preyMovement;

    void Awake()
    {
        preyMovement = this.GetComponent<ObjectMovement>();
    }
    void Start()
    {
        preyMovement.speed = 4f;

        /*
        SphereCollider trigger = gameObject.AddComponent<SphereCollider>();
        trigger.radius = 3f;
        trigger.isTrigger = true;
        */
    }

    #region Unity Methods

    void OnTriggerEnter(Collider other)
    {
        /*
        if (other.gameObject.GetComponent<Predator>())
        {
            //move away
            preyMovement.targetPosition = preyMovement.getRandomPosition();
            preyMovement.speed = 7f;
        }
        */
    }

    void OnCollisionEnter(Collision collision)
    {
        /*
        if(collision.gameObject.GetComponent<Predator>())
        {
            ResetPosition();
        }
        */
    }

    #endregion Unity Methods

    public void ResetPosition()
    {
        transform.position = new Vector3(-17, 0.5f, 10f);
        preyMovement.speed = 5f;
    }
}
