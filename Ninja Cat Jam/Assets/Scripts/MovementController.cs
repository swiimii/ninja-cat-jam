using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public BasicMovementBehavior[] behaviors;
    public float moveSpeed, jumpSpeed, shurikenVelocity;
    [Range(0, 40)]
    public float airControl;
    public bool[] powerupsAcquired = new bool[sizeof(b)];
    public GameObject projectilePrefab;
    public Animator playerAnimator;

    bool grounded;
    enum b {BasicMovement, DoubleJump}; //for navigating through the "BasicMovementBehavior" and "PowerupsAcquired" array


    // Update is called once per frame
    void Update()
    {
        //Update horizontal movement
        behaviors[(int)b.BasicMovement].OnHorizontalMove();


        //CheckJump
        if(Input.GetButtonDown("Jump"))
        {
            if(powerupsAcquired[(int)b.DoubleJump])
            {
                behaviors[(int)b.DoubleJump].OnJump();
            }
            else
            {
                behaviors[(int)b.BasicMovement].OnJump();
            }
        }


        if (Input.GetButtonUp("Fire1"))
        {
            behaviors[(int)b.BasicMovement].OnFire();
        }


    }


}
