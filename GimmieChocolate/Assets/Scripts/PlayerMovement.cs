using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        float xDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xDirection * 3f, rb.velocity.y); // left & right movement. if xDirection is negative we move opposite direction

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 4f);
        }
    }
}
