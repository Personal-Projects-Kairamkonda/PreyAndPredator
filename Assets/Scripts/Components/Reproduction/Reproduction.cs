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

<<<<<<< HEAD
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
=======
    public float rangeX=15f;
    public float rangeZ=10f;

    private int index;

    protected Transform childtransform;
>>>>>>> parent of b95239a (working constructor inhertance)

    /// <summary>
    /// Count of spawn entities.
    /// </summary>
    /// <returns> value</returns>
<<<<<<< HEAD
    public int childCount;
}
=======
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
>>>>>>> parent of b95239a (working constructor inhertance)
