using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpandTheif : MonoBehaviour
{

    public float jumpForce = 25f;


    public float groundCheckDistance = 10f;


    private bool isGrounded;


    private Rigidbody2D rb;

    public float moveSpeed = 7f;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        isGrounded = IsGrounded();


        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {

            JumpAction();
        }
    }

    void JumpAction()
    {

        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);


        Move(Vector2.right);
    }

    void Move(Vector2 direction)
    {

        rb.velocity = new Vector2(direction.x * moveSpeed, rb.velocity.y);
    }

    bool IsGrounded()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, ~LayerMask.GetMask("Player"));


        return hit.collider != null;
    }
}
