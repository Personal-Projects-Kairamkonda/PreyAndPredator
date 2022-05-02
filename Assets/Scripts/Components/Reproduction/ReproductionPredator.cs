using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReproductionPredator : Reproduction
{
    public Text dialougeText;

    void Awake()
    {
        childCount = 1;
    }

    void Start()
    {
        respawnPrey = true;
        StartCoroutine(SpawnPrey());
    }

    public override IEnumerator SpawnPrey()
    {
        yield return StartCoroutine(base.SpawnPrey());

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<PredatorStateManager>().dialougeText = this.dialougeText;
        }
    }
}
