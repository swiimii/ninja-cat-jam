using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementBehavior : MonoBehaviour
{
    public float moveSpeed, jumpSpeed;
    private GameObject feet;
    private FeetStatus feetStatus;
    private Rigidbody2D rb2d;

    private void Start()
    {
        feet = GameObject.FindGameObjectWithTag("Feet");
        rb2d = GetComponent<Rigidbody2D>();
        feetStatus = GetComponent<FeetStatus>();
    }
    public void OnHorizontalMove()
    {
        if (feetStatus.grounded)
        {
            rb2d.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), rb2d.velocity.y);
        }
        
        else if(Mathf.Abs(rb2d.velocity.x) < moveSpeed)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x + Input.GetAxisRaw("Horizontal"), rb2d.velocity.y);

        }
        else
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x * moveSpeed / Mathf.Abs(rb2d.velocity.x) - (0.15f * rb2d.velocity.x), rb2d.velocity.y);
        }
        
        
    }

    public void OnJump()
    {
        if(feetStatus.grounded)
        {
            var rb2d = GetComponent<Rigidbody2D>();
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
       

    }
}
