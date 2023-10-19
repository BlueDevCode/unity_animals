﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//@claudiacadec

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 50f;
    private float lowerBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if((this.transform.position.z > topBound) || 
          (this.transform.position.z  < lowerBound) )
        {
            Destroy(this.gameObject);
        }
    }

}
