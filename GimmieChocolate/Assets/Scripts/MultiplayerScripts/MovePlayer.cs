using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Mirror;

public class MovePlayer : NetworkBehaviour
{
    [SerializeField]
    private float speed = 2f;
    private float movement = 0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
        void FixedUpdate()
    {
        if (this.isLocalPlayer)
        {
            //Debug.Log("movement detected");
            movement = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(movement * speed, 0.0f);
        }
    }
}
