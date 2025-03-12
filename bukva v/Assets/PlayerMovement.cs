using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveInput;
    public float moveSpeed = 5f;
    private SpriteRenderer sprite;
    public float jumpForce = 5f;
    private int JumpCount = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && JumpCount > 0)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            JumpCount--;
        }
    }
    
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = move;
        if (moveInput < 0 )
        {
            sprite.flipX = true;
        }
        else if (moveInput > 0 )
        {
            sprite.flipX = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rub")
        {
            Destroy(collision.gameObject);
            DataHolder.DataH++;
        }
        else if(collision.gameObject.tag == "lava")
        {
            SceneManager.LoadScene(4);
        }
        if (collision.gameObject.tag == "Ground")
        {
            JumpCount = 2;
            DataHolder.DataToEnter = 1;
        }
        else if (collision.gameObject.tag != "Ground")
        {
            DataHolder.DataToEnter = 0;
        }
    }
}
