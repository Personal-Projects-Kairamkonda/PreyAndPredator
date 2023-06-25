/*-----------------------------------------------------------
 * Child class of Reproduction
 * It handles extra features to the preys
---------------------------------------------------------- */

using System.Collections;

/// <summary>
/// Child base of reproduction which uses properties and methods
/// </summary>
public class ReproductionPrey : Reproduction
{
     

    #region Unity methods

    void Awake()
    {
        childCount = 3;
    }

    void Start()
    {
        StartCoroutine(SpawnGameObject(childCount));
    }

    #endregion Unity methods

    #region Override methods

    public override IEnumerator SpawnGameObject(int getChildCount)
    {
        yield return StartCoroutine(base.SpawnGameObject(getChildCount));
    }

    #endregion Override methods
}
