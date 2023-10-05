using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private PlayerSettings playerSettings;

    private Vector3 rotY;

    private readonly string obstacleTag = "Obstacle";

    void FixedUpdate()
    {
        transform.position += transform.forward*playerSettings.speed*Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(obstacleTag))
        {
            rotY = Vector3.up * 90;
            transform.localEulerAngles += rotY;
        }
    }
}

[System.Serializable]
public class PlayerSettings
{
    public float speed = 1f;
}