using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbBehavior : EnemyBehavior
{
    public CapsuleCollider2D headHitbox;
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

    public override void OnWallHit()
    {
        base.OnWallHit();
        headHitbox.offset.Set(headHitbox.offset.x * -1, headHitbox.offset.y);
        Debug.Log("Flip");

    }

    public override void OnDamaged(int incomingDamage)
    {

    }



}
