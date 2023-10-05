/* ----------------------------------------------------------
 * Class features
 * Spawing Prey - Completed
 * Keep count of objects in scene 
---------------------------------------------------------- */

using System.Collections;
using UnityEngine;

public class Reproduction : MonoBehaviour
{
    #region Properties

    /// <summary>
    /// holds data spawn object
    /// </summary>
    public GameObject spawnPrefab;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    protected SpawnRange GetSpawnRange;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    protected SpawnValues GetSpawnValues;

    #endregion Properties

    #region Unity methods

    private void Awake()
    {
        for (int i = 0; i < 2; i++)
        {
            InitiateSpawn();
        }
    }

    #endregion

    #region  Custom methods

    /// <summary>
    /// 
    /// </summary>
    public virtual void InitiateSpawn()
    {
        SpawnObject(spawnPrefab, transform);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="spawnPrefab"></param>
    /// <param name="transform"></param>
    public void SpawnObject(GameObject spawnPrefab, Transform transform)
    {
        GameObject temp = Instantiate(spawnPrefab, transform.position, transform.rotation);
        temp.transform.SetParent(this.transform);
        temp.gameObject.name = $"{spawnPrefab.name} ({GetSpawnValues.gameObjectIndex}) ";
    }

    #endregion Custom methods
}

[System.Serializable]
public class SpawnRange
{
    /// <summary>
    /// max border of x axis
    /// </summary>
    public float rangeX = 15f;

    /// <summary>
    /// max border of z axis
    /// /// </summary>
    public float rangeZ = 10f;
}


[System.Serializable]
public class SpawnValues
{
    /// <summary>
    /// Used to store gameobject index
    /// </summary>
    public int gameObjectIndex;

    /// <summary>
    /// Count of spawn entities.
    /// </summary>
    /// <returns> value</returns>
    public int childCount;
}