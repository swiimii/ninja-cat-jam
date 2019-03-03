using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelBehavior : EnemyBehavior
{
    private double timeElapsed;
    public float dangerDistance;
   

    public GameObject target;
   
    
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 2 && Mathf.Abs(target.transform.position.x - transform.position.x) < dangerDistance)
        {
            timeElapsed = 0;
            var position = GetComponent<Transform>().position;
            position.y += 5;
            var acorn = Instantiate(projectilePrefab);
            acorn.GetComponent<Transform>().position = position;
            acorn.GetComponent<Rigidbody2D>().velocity = Acorn.CalcVelocity(target.GetComponent<Transform>().position, acorn.GetComponent<Transform>().position);
            GetComponent<Animator>().SetBool("OnThrow",true);
            
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
