﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//@claudiacadec
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed= 10.0f;
    public float xRange= 15.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
        if( transform.position.x< -xRange){
           transform.position = new Vector3(x:-xRange, 
           transform.position.y,
           transform.position.z);
        }
        if(transform.position.x>15){
            transform.position= new Vector3(x:xRange,
            transform.position.y,
            transform.position.z);
        }

    

     //Acciones del Personaje
      if (Input.GetKey(KeyCode.Space))
      {
        Instantiate(projectilePrefab,
        transform.position,
        projectilePrefab.transform.rotation);
      }



}
}





