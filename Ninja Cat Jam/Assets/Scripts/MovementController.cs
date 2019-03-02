using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public BasicMovementBehavior[] behaviors;
    public BoxCollider2D feet;

    enum b {BasicMovement, DoubleJump}; //for navigating through the "BasicMovementBehavior" and "PowerupsAcquired" array
    bool[] powerupsAcquired = new bool[sizeof(b)];

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
        


    }
}
