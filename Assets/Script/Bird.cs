using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    public static bool gameOver;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& !gameOver)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 150);
            anim.Play("Flap");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // if(collision.gameObject.tag == "Enemy")
       // {
            anim.Play("Die");
            gameOver = true;
        //}

        GameControl.instance.BirdDied();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            GameControl.instance.coinScore();
        }
    }
}
