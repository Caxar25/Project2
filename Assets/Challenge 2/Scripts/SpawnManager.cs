using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnZMax = -1;
    private float spawnZMin = -33;
    private float spawnPosY = 25;
    private Vector3 spawnPos;
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private int RandomSpawn;

    
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Спавн случайного шара на рандомной позиции
    void SpawnRandomBall ()
    {
        float randomX = Random.Range(spawnLimitXLeft, spawnLimitXRight);
        float randomZ = Random.Range(spawnZMin,spawnZMax);
        // Генерация рандомного индекса и случайной позиции 
        spawnPos = new Vector3(randomX, spawnPosY, randomZ);

       RandomSpawn = Random.Range(0,3); 
        // Создание шара
        Instantiate(ballPrefabs[RandomSpawn], spawnPos, ballPrefabs[RandomSpawn].transform.rotation);
    }

}
