/* ----------------------------------------------------------
 * Class features
 * Spawing Prey - Completed
 * Keep count of objects in scene 
---------------------------------------------------------- */

using System.Collections;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
   protected void  Reproduction()
    {
        
    }

    #region Properties

    /// <summary>
    /// holds data spawn object
    /// </summary>
    public GameObject spawnPrefab;

    /// <summary>
    /// max border of x axis
    /// </summary>
    public float rangeX=15f;

    /// <summary>
    /// max border of z axis
    /// /// </summary>
    public float rangeZ=10f;

    /// <summary>
    /// Used to store gameobject index
    /// </summary>
    private int gameObjectIndex;

    /// <summary>
    /// Count of spawn entities.
    /// </summary>
    /// <returns> value</returns>
    protected int childCount;

    #endregion Properties

    #region  Custom methods

    /// <summary>
    /// Object spawner 
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerator SpawnGameObject(int getChildCount)
    {
        Debug.Log($"Current child count is {childCount}");

        while (gameObjectIndex>getChildCount)
        {
            GameObject temp = Instantiate(spawnPrefab, transform.position, transform.rotation);
            temp.transform.SetParent(this.transform);
            temp.gameObject.name = $"{spawnPrefab.name} ({gameObjectIndex.ToString()}) ";
               
            gameObjectIndex++;

           ObjectMovement tempObjectMovement=temp.GetComponent<ObjectMovement>();

           tempObjectMovement.rangeX= this.rangeX;
           tempObjectMovement.rangeZ= this.rangeZ;
           tempObjectMovement.targetPosition = tempObjectMovement.getRandomPosition();

            yield return new WaitForSeconds(1f);
        }
    }

    #endregion Custom methods
}
