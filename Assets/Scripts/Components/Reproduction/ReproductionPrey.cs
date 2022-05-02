/*Child class of Reproduction
 * It handles extra features to the preys
 */

using System.Collections;
using UnityEngine;

public class ReproductionPrey : Reproduction
{
    void Awake()
    {
        childtransform = this.transform;
        childCount = 3;
    }

    // Start is called before the first frame update
    void Start()
    {
        respawnPrey = true;
        StartCoroutine(SpawnPrey());
    }

    public override IEnumerator SpawnPrey()
    {
        yield return StartCoroutine(base.SpawnPrey());
    }

}
