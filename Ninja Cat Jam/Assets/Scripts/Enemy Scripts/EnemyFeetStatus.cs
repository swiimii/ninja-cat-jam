using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFeetStatus : MonoBehaviour
{
    public bool grounded = false;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }


    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
