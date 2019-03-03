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
}
