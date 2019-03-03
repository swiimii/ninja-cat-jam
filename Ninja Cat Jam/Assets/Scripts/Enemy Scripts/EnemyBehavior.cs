using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehavior : MonoBehaviour
{
    protected int direction = -1;
    protected float moveSpeed, jumpSpeed;
    protected GameObject projectilePrefab;
    protected EnemyFeetStatus feet;
    protected Animator spriteAnimator;

    protected virtual void Start()
    {
        moveSpeed = GetComponent<EnemyMovementController>().moveSpeed;
        jumpSpeed = GetComponent<EnemyMovementController>().jumpSpeed;
        feet = GetComponent<EnemyMovementController>().feet.GetComponent<EnemyFeetStatus>() ;
        spriteAnimator = GetComponent<EnemyMovementController>().spriteAnimator;


    }
    public abstract void OnHorizontalMove();

    public abstract void OnJump();


    public abstract void OnPlayerHit();

    public virtual void OnDamaged(int incomingDamage)
    {
        
    }

    public abstract void SetDirection(int i);

    public int GetDirection()
    {
        return direction;
    }

}
