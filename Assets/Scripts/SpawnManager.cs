using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int animalIndex;

    // Update is called once per frame
    void Update()
    {
        if (animalIndex >=0 && animalIndex < enemies.Length){
            if (Input.GetKeyDown(KeyCode.S))
            Instantiate( enemies [animalIndex],
            new Vector3(0,0,transform.position.z),
            enemies[animalIndex].transform.rotation);
        }
        
    }
}
