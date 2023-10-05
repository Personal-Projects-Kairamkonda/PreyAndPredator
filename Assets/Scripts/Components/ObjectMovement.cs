using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    public Vector3 targetPosition;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private PlayerSettings playerSettings;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private SpawnRange GetSpawnRange;


    // Fixed Update is called once per frame
    void FixedUpdate()
    {
        // Check the distance between the animal and it's target position
        float dist = Vector3.Distance(transform.position, new Vector3(targetPosition.x, transform.position.y, targetPosition.z));

        // Check if the distance is less than or equal to 1
        if (dist <= 1)
        {
            // Set the target position to a random position
            targetPosition = getRandomPosition();
        }

        // Move the animal
        Move(targetPosition);
    }

    // Move method
    public void Move(Vector3 targetPosition)
    {
        // Create a new target position so the animal doesn't move on the y axis
        Vector3 target = new Vector3(targetPosition.x, transform.position.y, targetPosition.z);

        // Move to the target position
        transform.position = Vector3.MoveTowards(transform.position, target, playerSettings.speed * Time.deltaTime);

        // Look at the target position
        transform.LookAt(target);
    }

    // A method to get a random position on the map
    public Vector3 getRandomPosition()
    {
        // Create a random position
        Vector3 position = new Vector3(Random.Range(-GetSpawnRange.rangeX, GetSpawnRange.rangeX),
                                        5,
                                       Random.Range(-GetSpawnRange.rangeZ, GetSpawnRange.rangeZ));

        // Check if its above the ground
        if (!Physics.Raycast(position, Vector3.down, 10))
        {
            // Get a new random position
            position = getRandomPosition();
        }

        // Return the random position
        return position;
    }
}
