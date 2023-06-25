/* Class features
 * Spawing Prey - Completed
 * Keep count of objects in scene 
 */

using System.Collections;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
    #region Properties
    public GameObject prefab;

    public bool respawnPrey;

    public float rangeX=15f;
    public float rangeZ=10f;

    private int index;

    protected Transform childtransform;

    /// <summary>
    /// Count of spawn entities.
    /// </summary>
    /// <returns> value</returns>
    protected int childCount;

    #endregion Properties

    #region  Unity Methods

    void Update()
    {
        if (transform.childCount>childCount)
        {
            respawnPrey = false;
        }
    }

    #endregion Unity Methods

    #region  Custom methods

    /// <summary>
    /// Prey spawner 
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerator SpawnPrey()
    {
        while (respawnPrey)
        {
            GameObject temp = Instantiate(prefab, transform.position, transform.rotation);
            temp.transform.SetParent(this.transform);
            temp.gameObject.name = prefab.name+"("+index++.ToString()+ ")";

           ObjectMovement tempObjectMovement=temp.GetComponent<ObjectMovement>();

           tempObjectMovement.rangeX= this.rangeX;
           tempObjectMovement .rangeZ= this.rangeZ;
           tempObjectMovement.targetPosition = tempObjectMovement.getRandomPosition();

            yield return new WaitForSeconds(1f);
        }
    }
    #endregion Custom methods
}
