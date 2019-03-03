using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public EnemyBehavior behavior;
    public float moveSpeed, jumpSpeed;
    public GameObject projectilePrefab, feet;
    public Animator spriteAnimator;
    public float leftOffset, rightOffset;

    bool grounded;
    //for navigating through the "BasicMovementBehavior" and "PowerupsAcquired" array


    // Update is called once per frame
    void Update()
    {
        //Update horizontal movement
        behavior.OnHorizontalMove();


        //CheckJump
        if (false)
        {
            behavior.OnJump();
        }


        //Check OnWallHit
        RaycastHit2D hit;
        Debug.DrawRay(transform.position, new Vector3(leftOffset-.2f, 0, 0));
        hit = Physics2D.Raycast(transform.position + new Vector3(leftOffset, 0, 0), new Vector3(-1, 0, 0), 1);
        if(hit && !hit.collider.gameObject.CompareTag("Projectile"))
        {
            if (hit.collider.gameObject.CompareTag("Player") && behavior.GetDirection() < 0)
            {
                hit.collider.gameObject.GetComponent<PlayerHealthScript>().TakeDamage(1);
            }
            behavior.SetDirection(1);
        }



        Debug.DrawRay(transform.position, new Vector3(rightOffset+.2f, 0, 0));
        hit = Physics2D.Raycast(transform.position + new Vector3(rightOffset, 0, 0), new Vector3(1, 0, 0), 1);
        if (hit && !hit.collider.gameObject.CompareTag("Projectile"))
        {
            if (hit.collider.gameObject.CompareTag("Player") && behavior.GetDirection() > 0)
            {
                hit.collider.gameObject.GetComponent<PlayerHealthScript>().TakeDamage(1);
            }
            behavior.SetDirection(-1);
            
        }


    }


}
