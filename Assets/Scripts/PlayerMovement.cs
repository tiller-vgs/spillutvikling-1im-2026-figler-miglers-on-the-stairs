using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 10f;
    public float jumpForce = 12f;

    private LayerMask groundLayerMask;

    private float xInput;
    private bool yJumping;
    private bool isGrounded;
    private Collider2D playerCollider;
    private SpriteRenderer spriteRenderer;
    private bool flipX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        groundLayerMask = LayerMask.GetMask("ground");

        Debug.Log($"groundLayerMask {groundLayerMask.ToSafeString()}");
    }

    void Update()
    {
        // 1. Get the input every frame
        xInput = Input.GetAxisRaw("Horizontal");
        yJumping = Input.GetButton("Jump");
    }

    void FixedUpdate()
    {
        // 2. Apply the physics on the fixed physics step
        rb.linearVelocity = new Vector2(moveSpeed * xInput, rb.linearVelocity.y);
        if (xInput < 0 && xInput != 0)
            flipX = true;
        else if (xInput > 0 && xInput != 0)
            flipX = false;
        if(spriteRenderer != null)
            spriteRenderer.flipX = flipX;

        isGrounded = CheckGrounded();
        //Debug.Log($"Is grounded? = {isGrounded}");
        if (yJumping && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private bool CheckGrounded()
    {
        // Check if the player body is touching a ground layer
        if (groundLayerMask != 0)
            return playerCollider.IsTouchingLayers(groundLayerMask);

        return false;
    }
}