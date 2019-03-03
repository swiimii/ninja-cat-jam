using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetStatus : MonoBehaviour
{
    public bool grounded = false;
    private DoubleJumpBehavior dbJump;
    private void Start()
    {
        dbJump = GetComponent<DoubleJumpBehavior>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            dbJump.SetJumpsLeft(2);
        }


    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
            dbJump.SetJumpsLeft(1);
        }
    }
    
    /*
    public void Update()
    {
        Debug.DrawRay(transform.position, new Vector3(0, -6, 0));

        grounded = Physics2D.Raycast(transform.position , new Vector2(0,-1), 6f, LayerMask.NameToLayer("Ground"));
    }
    */
}
