using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantSquirrelScript : EnemyBehavior
{
    private double timeElapsed;
    public float dangerDistance;
    public float attackInterval = 2;
    public Transform AcornSpawnPoint;


    public GameObject target;


    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > attackInterval && Mathf.Abs(target.transform.position.x - transform.position.x) < dangerDistance)
        {
            timeElapsed = 0;
            var position = GetComponent<Transform>().position;
            position.y += 5;
            var acorn = Instantiate(projectilePrefab,AcornSpawnPoint.position,Quaternion.identity,AcornSpawnPoint);
            acorn.GetComponent<Transform>().position = position;
            acorn.GetComponent<Rigidbody2D>().velocity = Acorn.CalcVelocity(.5f * target.GetComponent<Transform>().position, .5f * acorn.GetComponent<Transform>().position);
            GetComponent<Animator>().SetBool("OnThrow", true);

        }
    }

    public override void OnHorizontalMove()
    {
    }

    public override void OnJump()
    {
    }

    public override void OnPlayerHit()
    {
    }

    public override void SetDirection(int i)
    {
        //throw new System.NotImplementedException();
    }

}
