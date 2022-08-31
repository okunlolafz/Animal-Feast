using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    private float SpawnPosZ = 20;
    private float SpawnRangeX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    // Spawn animals randomly
    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalprefabs.Length);
        Vector3 spawnPos = new Vector3((Random.Range(-20,20)),0,SpawnPosZ);
        Instantiate(animalprefabs[animalIndex], spawnPos, animalprefabs[animalIndex].transform.rotation);
    }
}
