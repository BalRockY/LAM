using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 100;
    public float maxSpeed = 7;
    public float jumpForce = 15;

    public bool onGround; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * direction * speed);

        if (rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }
        if (rb.velocity.x < -maxSpeed)
        {
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("KillLine"))
            Destroy(gameObject);
    }
}
