﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int animalIndex;
    private float spawnRangeX = 20f;
    private float spawnPosZ ;

   [SerializeField,Range(2,5)]
    public float startDelay= 2.0f;
     [SerializeField,Range(0.1f,3f)]
    public float spawnInterval= 0.1f ;

    private void Star(){
        spawnPosZ = this.transform.position.z;
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);

    }

    
    private void SpawnRandomAnimal()
    
        {
             float xRand= Random.Range(-spawnRangeX, spawnRangeX);
             Vector3 spawnPos  = new Vector3(xRand,0,spawnPosZ);

             animalIndex = Random.Range(0,enemies.Length);
            Instantiate( enemies [animalIndex],
            spawnPos,
            enemies[animalIndex].transform.rotation);
         }
        
    





}
  