using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbBehavior : EnemyBehavior
{
    public override void OnHorizontalMove()
    {
        if (feet.grounded)
        {
            var rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
        }
    }

    public override void OnJump()
    {

    }


    public override void OnPlayerHit()
    {
        
    }

    public override void SetDirection(int i)
    {
        direction = i / Mathf.Abs(i);

        Vector3 scale = transform.localScale;
        scale.x = -i;
        transform.localScale = scale;
    }





}
