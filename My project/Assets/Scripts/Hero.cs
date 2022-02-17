using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int xVelocity = 4;
    public int yVelocity = 5;

    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        updatePlayerPosition();
    }

    private void updatePlayerPosition()
    {
        float moveInput = Input.GetAxis("Horizontal");
        float jumpInput = Input.GetAxis("Jump");

        if (moveInput < 0)
            rigidBody.velocity = new Vector2(-xVelocity, rigidBody.velocity.y);
        else if (moveInput > 0)
            rigidBody.velocity = new Vector2(xVelocity, rigidBody.velocity.y);
        
        if (jumpInput > 0)
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, yVelocity);
        
    }
}
