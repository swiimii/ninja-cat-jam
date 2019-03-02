using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class BasicMovementBehavior : MonoBehaviour
{
    public float moveSpeed, jumpSpeed;
    public GameObject prefab;

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

    public void OnFire(Transform startPosition, Vector2 velocity)
    {
        var position = startPosition.position;
        position.x += 2;
        GameObject projectile = Instantiate(prefab, startPosition);
        projectile.GetComponent<Transform>().position = position;
        projectile.AddComponent<Rigidbody2D>();
        projectile.AddComponent<BoxCollider2D>();

        var rigidBody = projectile.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(velocity.x/3 + 50, velocity.y/3 + 20);
        rigidBody.gravityScale = 0.5F;

    }
}
