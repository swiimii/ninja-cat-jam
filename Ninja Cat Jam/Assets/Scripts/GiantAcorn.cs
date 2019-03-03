using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantAcorn : Acorn
{
    // Start is called before the first frame update
    public Vector2 SpawnLocation;
    void Start()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("Boss").GetComponent<Collider2D>());
        //GetComponent<Rigidbody2D>().gravityScale = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
