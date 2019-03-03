using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementBehavior : MonoBehaviour
{
    protected float moveSpeed, jumpSpeed, airControl;
    protected GameObject feet;
    protected FeetStatus feetStatus;
    protected Rigidbody2D rb2d;

    private void Start()
    {
        feet = GameObject.FindGameObjectWithTag("Feet");
        rb2d = GetComponent<Rigidbody2D>();
        feetStatus = GetComponent<FeetStatus>();
    }
    public void OnHorizontalMove()
    {
        moveSpeed = GetComponent<MovementController>().moveSpeed;
        jumpSpeed = GetComponent<MovementController>().jumpSpeed;
        airControl = GetComponent<MovementController>().airControl;

        if (rb2d.velocity.x != 0)
        {
            //Flip Sprite
            GetComponent<SpriteRenderer>().flipX = rb2d.velocity.x < 0;
        }

        if (feetStatus.grounded)
        {
            rb2d.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"), rb2d.velocity.y);
        }
        
        else if(Mathf.Abs(rb2d.velocity.x) < moveSpeed)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x + Input.GetAxisRaw("Horizontal") * airControl, rb2d.velocity.y);

        }
        if (Mathf.Abs(rb2d.velocity.x) >= moveSpeed) 
        {
            //sets the velocity to just below the max airspeed
            rb2d.velocity = new Vector2((moveSpeed - .01f) * rb2d.velocity.x / Mathf.Abs(rb2d.velocity.x), rb2d.velocity.y) ;
        }
        
        
        
        
    }

    public virtual void OnJump()
    {
        if(feetStatus.grounded)
        {
            var rb2d = GetComponent<Rigidbody2D>();
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
       

    }
}
