using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sprite;
    private float xDirection = 0f;
    [SerializeField]private float speed = 4f;
    [SerializeField]private float jumpVel = 7f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        
    }

    private void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xDirection * speed, rb.velocity.y); // left & right movement. if xDirection is negative we move opposite direction

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpVel);
        }

        ChangeAnimationState();
    }

    private void ChangeAnimationState()
    {
        // change animation state.
        if (xDirection > 0f) // moving right.
        {
            animator.SetBool("isRunning", true);
            sprite.flipX = false;
        }
        else if (xDirection < 0f) // moving left.
        {
            animator.SetBool("isRunning", true);
            // Make character face opposite direction.
            sprite.flipX = true;
        }
        else // idle
        {
            animator.SetBool("isRunning", false);
        }
    }
}
