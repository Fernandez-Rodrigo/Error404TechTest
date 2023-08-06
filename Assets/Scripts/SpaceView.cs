using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceView : MonoBehaviour
{
    [SerializeField] Dificulty dificulty;
    private bool spawnCoinNext;
    private int coinsSpawned;

    void Start()
    {
        InvokeRepeating("SpawnObject",5f, dificulty.SpawnTime());
        dificulty.GetTarget().GetComponent<Target>().targetDestroyed += this.SpawnCoin;
    }

    private void SpawnObject()
    {
        if (this.spawnCoinNext && this.coinsSpawned <= 5)
        {
            this.dificulty.GetCoin().gameObject.SetActive(true);
            this.dificulty.GetCoin().SetTimeToDestroy(dificulty.SpawnTime());
            this.coinsSpawned++;
            return;
        }
        coinsSpawned = 0;
        spawnCoinNext = false;
        int randomItem = UnityEngine.Random.Range(0, dificulty.SpawnProbability());

        var selectedObject = dificulty.SelectObjectToSpawn(randomItem);
        selectedObject?.gameObject.SetActive(true);
    }

    void SpawnCoin()
    {
        this.spawnCoinNext = true;
    }
}
