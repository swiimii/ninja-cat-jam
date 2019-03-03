using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    public int startingHealth;
    public Canvas deathScreen;
    public GameObject enemiesParent;

    private int health;
    private bool dead;
    private void Start()
    {
        health = startingHealth;
    }

    private void Update()
    {
        var sprite = GetComponent<SpriteRenderer>();
        if (health != 1)
        {
            sprite.color = new Color(255, (255 + sprite.color.g) / 2, (255 + sprite.color.b) / 2);
        }
    }

    public void TakeDamage(int damage)
    {
        //decrement health
        health -= damage;

        //recoil user
        GetComponent<Rigidbody2D>().velocity.Set(transform.forward.x * -8f, 8f);

        //briefly change color (stays if at 1 health)
        var sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(255, sprite.color.g-30, sprite.color.b-30);
        if (health == 1)
        {
            sprite.color = new Color(255, 200, 200);
        }
        //check dead
        if (health <= 0)
        {
            dead = true;
            deathScreen.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

    public bool isDead()
    {
        return dead;
    }
}
