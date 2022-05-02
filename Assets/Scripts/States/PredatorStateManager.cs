using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PredatorStateManager : MonoBehaviour
{
    public Text dialougeText;

    public bool collidedWithPrey=false;
    public bool iamFat = false;
    public bool iamBack = false;

    PredatorBaseState currentState;

    public PredatorIdleState predatorIdleState = new PredatorIdleState();
    public PredatorEvolveState predatorEvolveState = new PredatorEvolveState();
    public PredatorDeathState predatorDeathState = new PredatorDeathState();
    public PredatorReproduceState predatorReproduceState = new PredatorReproduceState();

    public ObjectMovement predMovement;


    void Awake()
    {
        dialougeText = this.GetComponent<Text>();
    }

    void Start()
    {
        currentState = predatorIdleState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);

        if (dialougeText!=null)
        {
          UpdateDialougeText();
        }
    }

    public void SwitchState(PredatorBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    private void UpdateDialougeText()
    {
        Debug.Log(currentState.message);
        dialougeText.text = currentState.message;
    }

}
