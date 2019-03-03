using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbBehavior : EnemyBehavior
{

    // Update is called once per frame



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

    public override void OnWallHit()
    {
        direction *= -1;
    }

    public override void OnPlayerHit()
    {
        
    }

    public override void OnDamaged(int incomingDamage)
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            OnWallHit();
        }
    }


}
