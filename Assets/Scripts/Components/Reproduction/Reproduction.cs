using System.Collections;
using UnityEngine;

/* Class features
 * Spawing Prey - Completed
 * Keep count of objects in scene 
 */

public class Reproduction : MonoBehaviour
{
    public GameObject prefab;

    public bool respawnPrey;

    public float rangeX=15f;
    public float rangeZ=10f;

    private int index;

    protected Transform childtransform;
    protected int childCount;

    void Update()
    {
        if (transform.childCount>childCount)
        {
            respawnPrey = false;
        }
    }

    public virtual IEnumerator SpawnPrey()
    {
        while (respawnPrey)
        {
            GameObject temp = Instantiate(prefab, transform.position, transform.rotation);
            temp.transform.SetParent(this.transform);
            temp.gameObject.name = index++.ToString();

           ObjectMovement tempObjectMovement=temp.GetComponent<ObjectMovement>();

           tempObjectMovement.rangeX= this.rangeX;
           tempObjectMovement .rangeZ= this.rangeZ;
           tempObjectMovement.targetPosition = tempObjectMovement.getRandomPosition();

            yield return new WaitForSeconds(1f);
        }
    }
    
}
