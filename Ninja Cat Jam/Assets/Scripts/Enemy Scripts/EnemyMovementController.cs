using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public EnemyBehavior[] behaviors;
    public float moveSpeed, jumpSpeed;
    public GameObject projectilePrefab, feet;
    public Animator spriteAnimator;

    bool grounded;
    enum b { BasicEnemyMovement, BirbMovement }; //for navigating through the "BasicMovementBehavior" and "PowerupsAcquired" array


    // Update is called once per frame
    void Update()
    {
        //Update horizontal movement
        behaviors[(int)b.BasicEnemyMovement].OnHorizontalMove();


        //CheckJump
        if (Input.GetButtonDown("Jump"))
        {
            
            behaviors[(int)b.BasicEnemyMovement].OnJump();
            
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            behaviors[(int)b.BasicEnemyMovement].OnWallHit();
        }
    }
}
