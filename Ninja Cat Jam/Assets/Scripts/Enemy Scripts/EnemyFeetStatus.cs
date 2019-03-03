using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFeetStatus : MonoBehaviour
{
    public bool grounded = false;

    /*
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = (Physics.Raycast(playerBox.transform.position, Vector3.down, 1f, LayerMask.NameToLayer("Ground"))); ;
        }


    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
    */

    private void Update()
    {
        var dist = 6;
        var dir = new Vector3(0, -1, 0);
        Debug.DrawRay(transform.position, dir * dist, Color.green);
        grounded = Physics2D.Raycast(transform.position,dir,LayerMask.NameToLayer("Ground"));
    }
}
