using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelBehavior : EnemyBehavior
{
    private double timeElapsed;
    public GameObject projectilePrefab;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 2)
        {
            timeElapsed = 0;
            var position = GetComponent<Transform>().position;
            position.y += 5;
            var acorn = Instantiate(projectilePrefab);
            acorn.GetComponent<Transform>().position = position;
            acorn.GetComponent<Rigidbody2D>().velocity = Acorn.CalcVelocity(player.GetComponent<Transform>().position, acorn.GetComponent<Transform>().position);
            
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
