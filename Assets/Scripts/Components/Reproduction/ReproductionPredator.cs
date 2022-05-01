using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproductionPredator : Reproduction
{
    void Awake()
    {
        childCount = 1;
    }

    void Start()
    {
        respawnPrey = true;
        StartCoroutine(SpawnPrey());
    }

}
