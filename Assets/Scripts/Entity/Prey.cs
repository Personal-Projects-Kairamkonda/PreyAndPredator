using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : MonoBehaviour
{
    private ObjectMovement preyMovement;
    private Radius preyRadius;

    void Awake()
    {
        preyMovement = this.GetComponent<ObjectMovement>();
    }
    void Start()
    {
        preyMovement.speed = 4f;
    }

    #region Unity Methods

    void OnTriggerEnter(Collider other)
    {
        Predator predator = other.GetComponent<Predator>();

        if (predator)
        {
            //Debug.Log("Escape from predator");
            preyMovement.Move(preyMovement.getRandomPosition());
            preyMovement.speed *= 2; ;
        }
    }


    void OnTriggerExit(Collider other)
    {
        Predator predator = other.GetComponent<Predator>();

        if (predator)
            preyMovement.speed = 4f;

    }

    #endregion Unity Methods

    public void ResetPosition()
    {
        transform.position = new Vector3(-17, 0.5f, 10f);
        preyMovement.speed = 5f;
    }
}
