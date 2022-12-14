using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    public float speedBuffAmount;
    public float jumpBuffAmount;
    public int startingPieces;
    public int piecesNeeded;
    public static bool grounded = false;
    public float knockbackAmount;
    public static float knockbackCounter;
    public static float knockbackTotalTime;
    public static bool knockFromRight;
    public float KBCounter;
    public float KBTotalTime;
    public bool KFRight;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        knockFromRight = KFRight;
        knockbackCounter = KBCounter;
        knockbackTotalTime = KBTotalTime;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.isDead == false)
        {
            float xInput = Input.GetAxis("Horizontal");

            Vector2 velocity = rb.velocity;
            if (knockbackCounter <= 0)
            {
                velocity.x = xInput * moveSpeed;
                rb.velocity = velocity;
            }
            else
            {
                if (knockFromRight == true)
                {
                    //velocity.x = xInput * moveSpeed;
                    rb.velocity = new Vector2(-knockbackAmount, knockbackAmount);
                }
                if (knockFromRight == false)
                {
                    //velocity.x = xInput * moveSpeed;
                    rb.velocity = new Vector2(-knockbackAmount, knockbackAmount);
                }
                knockbackCounter -= Time.deltaTime;
            }

            if (Input.GetButtonDown("Jump") && grounded == true)
            {
                animator.SetTrigger("Jump");
                rb.AddForce(new Vector2(0, 100 * jumpSpeed));
                grounded = false;

            }
            if (rb.velocity.y < -0.1f && !grounded)
            {
                animator.SetTrigger("Fall");
            }
            animator.SetFloat("xInput", xInput);
            animator.SetBool("grounded", grounded);
            if (xInput < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (xInput > 0)
            {
                spriteRenderer.flipX = false;
            }
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                grounded = true;
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                grounded = false;
            }
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SpeedPowerUp")
        {
            moveSpeed += speedBuffAmount;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "JumpPowerUp")
        {
            jumpSpeed += jumpBuffAmount;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "WeaponPieces")
        {
            startingPieces++;
            Destroy(collision.gameObject);
            if (startingPieces >= piecesNeeded)
            {
                startingPieces -= piecesNeeded;
            }
        }
    }
}


