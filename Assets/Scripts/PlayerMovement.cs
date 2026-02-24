using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    private float xInput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. Get the input every frame
        xInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate() 
    {
        // 2. Apply the physics on the fixed physics step
        rb.linearVelocity = new Vector2(moveSpeed * xInput, rb.linearVelocity.y);
    }
}