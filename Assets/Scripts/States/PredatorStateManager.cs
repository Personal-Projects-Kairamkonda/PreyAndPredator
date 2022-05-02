using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PredatorStateManager : MonoBehaviour
{
    public ObjectMovement predMovement;
    public Radius predradius;
    public Transform predSize;
    public Text dialougeText;
    public int predFatCount;

    public PredatorBaseState currentState;

    // Predator States
    public PredatorIdleState predatorIdleState = new PredatorIdleState();
    public PredatorEvolveState predatorEvolveState = new PredatorEvolveState();
    public PredatorDeathState predatorDeathState = new PredatorDeathState();
    public PredatorReproduceState predatorReproduceState = new PredatorReproduceState();


    void Awake()
    {
        dialougeText = this.GetComponent<Text>();
        predMovement = this.GetComponent<ObjectMovement>();
        predradius = this.GetComponent<Radius>();
        predSize = this.transform.GetChild(0).gameObject.transform;
    }

    void Start()
    {
        SphereCollider triggerCollider = gameObject.AddComponent<SphereCollider>();
        triggerCollider.radius = 4;
        triggerCollider.isTrigger = true;

        BoxCollider collisionCollider = gameObject.AddComponent<BoxCollider>();


        currentState = predatorIdleState;
        currentState.EnterState(this);
    
    }

    void Update()
    {
        currentState.UpdateState(this);

        if (dialougeText != null)
            UpdateDialougeText();
    }

    public void SwitchState(PredatorBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
    
    void OnTriggerStay(Collider otherObject)
    {
        currentState.OnTriggerStay(this, otherObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    private void UpdateDialougeText()
    {
        //Debug.Log(currentState.message);
        dialougeText.text = currentState.message;
    }

    public void predIncrementSize()
    {
        float x = predSize.transform.localScale.x + 0.5f;
        float z = predSize.transform.localScale.z + 0.5f;

        predSize.transform.localScale = new Vector3(x, 0, z);
    }

    public void PredResetData()
    {
        predSize.transform.localScale = new Vector3(1, 0, 1);
        this.transform.position = new Vector3(17, 0.5f, -10);
        predradius.triggerRadius = 4;
        predradius.DrawCircle(130, predradius.triggerRadius);
        predMovement.speed = 3f;
        predFatCount = 0;
    }

}
