﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//@claudiacadec
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed= 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
        if( transform.position.x< -15){
           transform.position = new Vector3(x:-15, transform.position.y,transfor.position.z);
        }
    }
}