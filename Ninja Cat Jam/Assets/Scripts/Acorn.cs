using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            Destroy(collision.collider.gameObject);
        }
        Destroy(this.gameObject);
    }

    public static Vector2 CalcVelocity(Vector2 playerPosition, Vector2 acornPosition)
    {
        int umph = (int)(playerPosition.x - acornPosition.x) * 2;

        return new Vector2(umph, 1);
    }

}
