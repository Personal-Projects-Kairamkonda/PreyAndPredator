using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReproductionPredator : Reproduction
{
    [Tooltip("Dialouge text for the predator")]
    public Text dialougeText;

    void Awake()
    {
        //childCount = 0;
    }

    void Start()
    {
<<<<<<< HEAD
        //StartCoroutine(SpawnGameObject(childCount));
    }

   
=======
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

        StopCoroutine(SpawnPrey());
    }
>>>>>>> parent of b95239a (working constructor inhertance)
}
