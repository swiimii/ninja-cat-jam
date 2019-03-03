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
        Debug.DrawRay(transform.position + new Vector3(0, -6, 0), new Vector2(0, -1), Color.green);
        grounded = Physics2D.Raycast(transform.position + new Vector3(0,-6,0),new Vector2(0,-1), 1f);
    }
}
