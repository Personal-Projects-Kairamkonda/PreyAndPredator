using System.Collections;
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
        //StartCoroutine(SpawnGameObject(childCount));
    }

   
}
