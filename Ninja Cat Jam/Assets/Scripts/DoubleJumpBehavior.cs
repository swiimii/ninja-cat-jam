using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpBehavior : BasicMovementBehavior
{
    public int jumpsLeft;

    public override void OnJump()
    {
        if (feetStatus.grounded || jumpsLeft > 0)
        {
            var rb2d = GetComponent<Rigidbody2D>();
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            jumpsLeft -= 1;
        }
    }


    public void SetJumpsLeft(int val)
    {
        jumpsLeft = val;
    }
}
