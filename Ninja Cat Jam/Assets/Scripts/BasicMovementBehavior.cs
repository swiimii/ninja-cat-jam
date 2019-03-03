using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class BasicMovementBehavior : MonoBehaviour
{
    protected float moveSpeed, jumpSpeed, airControl;
    protected GameObject feet, projectilePrefab;
    protected FeetStatus feetStatus;
    protected Rigidbody2D rb2d;
    protected Animator playerAnimator;


    private void Start()
    {
        playerAnimator = GetComponent<MovementController>().playerAnimator;
        feet = GameObject.FindGameObjectWithTag("Feet");
        rb2d = GetComponent<Rigidbody2D>();
        feetStatus = GetComponent<FeetStatus>();
        projectilePrefab = GetComponent<MovementController>().projectilePrefab;
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
            playerAnimator.SetBool("isRunning", true) ;
        }
        else
        {
            playerAnimator.SetBool("isRunning", false);
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

    public void OnFire(Transform startPosition, Vector2 velocity)
    {
        var position = startPosition.position;
        position.x += 2;
        GameObject projectile = Instantiate(projectilePrefab, startPosition);
        projectile.GetComponent<Transform>().position = position;

        var rigidBody = projectile.GetComponent<Rigidbody2D>();
        rigidBody.velocity = Shuriken.CalcVelocity(startPosition.position);
        rigidBody.gravityScale = 0.5F;

    }
}
