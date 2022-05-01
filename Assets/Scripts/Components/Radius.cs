using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Radius : MonoBehaviour
{
    private LineRenderer circleRenderer;

    [Range(1, 5)]
    public float triggerRadius = 2f;

    void Awake()
    {
        circleRenderer = this.GetComponent<LineRenderer>();
        circleRenderer.useWorldSpace = false;
        circleRenderer.widthMultiplier = 0.2f;
        circleRenderer.material.color = Color.black;
    }

    // Start is called before the first frame update
    void Start()
    {
        DrawCircle(130, triggerRadius);
    }

    private void DrawCircle(int steps, float radius)
    {
        circleRenderer.positionCount = steps;

        for (int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumferenceProgress = (float) currentStep / steps;

            //value of TAU= 6.28 radians / 360 Degrees if strechted in a straight line 
            float currentRadians =  circumferenceProgress * 2 * Mathf.PI ;

            float xScaled = Mathf.Cos(currentRadians);
            float yScaled = Mathf.Sin(currentRadians);

            float x = xScaled * radius;
            float y = yScaled * radius;

            Vector3 currentPosition = new Vector3(x, -0.5f, y);

            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }
    
}
