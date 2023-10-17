/*Child class of Reproduction
 * It handles extra features to the preys
 */

using System.Collections;
using UnityEngine;

public class ReproductionPrey : Reproduction
{
<<<<<<< HEAD
     
    #region Unity methods

    void Awake()
    {
        
=======
    void Awake()
    {
        childtransform = this.transform;
        childCount = 3;
>>>>>>> parent of b95239a (working constructor inhertance)
    }

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        InitiateSpawn();
    }

    #endregion Unity methods

    #region Override methods

=======
        respawnPrey = true;
        StartCoroutine(SpawnPrey());
    }

    public override IEnumerator SpawnPrey()
    {
        yield return StartCoroutine(base.SpawnPrey());
    }
>>>>>>> parent of b95239a (working constructor inhertance)

}
