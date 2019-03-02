using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HelloUnity : MonoBehaviour
{
    public SpriteRenderer myBoy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = GetComponent<Transform>();

        if (transform.position.y < -3) {

            var x = GetComponent<Rigidbody2D>();
            x.velocity = new Vector3(0, 0);
            transform.position = new Vector3(0, 0);
        }
    }
}
