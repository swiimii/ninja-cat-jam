using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementBehavior : MonoBehaviour
{
    public float moveSpeed, jumpSpeed;

    public void OnHorizontalMove()
    {

        var rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), rb2d.velocity.y);
    }

    public void OnJump()
    {
        var rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);

    }
}
