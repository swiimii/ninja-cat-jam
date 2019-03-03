using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    public int startingHealth;
    public float colorIntegrity;

    private int health;
    private bool dead;
    private void Start()
    {
        health = startingHealth;
    }

    private void Update()
    {


        if (health != 1 && colorIntegrity < 5)
        {
            GetComponent<SpriteRenderer>().color = new Color(255, Mathf.Lerp(100, 255, colorIntegrity ), Mathf.Lerp(100, 255, colorIntegrity),255);
            colorIntegrity +=Time.deltaTime / 5f;
        }


    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        //recoil user
        GetComponent<Rigidbody2D>().velocity.Set(transform.forward.x * -20f, 20f);

        colorIntegrity = 0;

        if (health <= 0)
        {
            dead = true;
            Destroy(gameObject);
        }
    }

    public bool IsDead()
    {
        return dead;
    }

}
