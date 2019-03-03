using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public EnemyBehavior behavior;
    public float moveSpeed, jumpSpeed;
    public GameObject projectilePrefab, feet;
    public Animator spriteAnimator;

    bool grounded;
    //for navigating through the "BasicMovementBehavior" and "PowerupsAcquired" array


    // Update is called once per frame
    void Update()
    {
        //Update horizontal movement
        behavior.OnHorizontalMove();


        //CheckJump
        if (Input.GetButtonDown("Jump"))
        {
            
            behavior.OnJump();
            
        }

        //Check OnWallHit
        {
            Debug.DrawRay(transform.position, new Vector3(-3, 0, 0));
        }


    }


}
