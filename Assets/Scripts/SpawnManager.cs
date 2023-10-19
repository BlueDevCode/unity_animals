using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int animalIndex;
    private float spawnRangeX = 20f;
    private float spawnPosZ;
    void Star(){
        spawnPosZ = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetKeyDown(KeyCode.S))
            {
             float xRand= Random.Range(-spawnRangeX, spawnRangeX);
             Vector3 spawnPos  = new Vector3(xRand,0,spawnPosZ);

             animalIndex = Random.Range(0,enemies.Length);
            Instantiate( enemies [animalIndex],
            spawnPos,
            enemies[animalIndex].transform.rotation);
         }
        
        
    }
}
  