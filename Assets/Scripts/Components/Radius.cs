using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Radius : MonoBehaviour
{
    private LineRenderer circleRenderer;

    // Start is called before the first frame update
    void Start()
    {
        circleRenderer = this.GetComponent<LineRenderer>();
        circleRenderer.material.color = Color.black;
        DrawCircle(130, 2);
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

            Vector3 currentPosition = new Vector3(x, 0, y);

            circleRenderer.SetPosition(currentStep, currentPosition);
        }
    }
    
}
