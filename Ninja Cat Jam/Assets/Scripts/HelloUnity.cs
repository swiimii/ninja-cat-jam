﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().position = new Vector3(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
