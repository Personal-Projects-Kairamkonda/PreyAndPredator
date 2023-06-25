using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ReproductionPredator : Reproduction
{
    [Tooltip("Dialouge text for the predator")]
    public Text dialougeText;

    void Awake()
    {
        childCount = 0;
    }

    void Start()
    {
        StartCoroutine(SpawnGameObject(childCount));
    }

    public override IEnumerator SpawnGameObject(int getChildCount)
    {
        yield return StartCoroutine(base.SpawnGameObject(getChildCount));

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<PredatorStateManager>().dialougeText = this.dialougeText;
        }

        
    }
}
