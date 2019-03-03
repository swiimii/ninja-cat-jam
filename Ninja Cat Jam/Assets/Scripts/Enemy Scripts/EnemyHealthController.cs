using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    public int startingHealth;
    public AudioSource hit;

    public int health;
    private bool dead;
    private void Start()
    {
        health = startingHealth;
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        hit.Play();
        print("test");

        //recoil user

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
