using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical; 
    private float speed = 14f;
    //private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    /* Start is called before the first frame update
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        //returns -1, 0, or 1 depending on the direction we are moving to the horiz/verti var
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 

        /*
        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            // lets you jump higher by long holding jump, shorter/lower when tap jump
            // assuming the math is that it slows down vertically when you are no longer pressing jump
        }
        */

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
    }

    /*
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        //creates an invisible circle at players feet, when it collides w ground layer we're allowed to jump
    }
    */

    private void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }


}
