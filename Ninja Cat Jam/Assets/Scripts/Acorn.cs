using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    double timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Destroy(this.gameObject);   
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealthScript>().TakeDamage(1);
        }
        if (collision.collider.gameObject.tag != "Enemy")
        {
            Destroy(this.gameObject);
        }
    }

    public static Vector2 CalcVelocity(Vector2 playerPosition, Vector2 acornPosition)
    {
        int umph = (int)(playerPosition.x - acornPosition.x) * 2;

        return new Vector2(umph, -15);
    }

}
