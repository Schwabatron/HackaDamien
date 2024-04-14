using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float jumpingPower = 16f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 8f;
    private bool jumping = false;
    public Animator animator;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        spriteRenderer.flipX = rb.velocity.x < 0f;
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && jumping == false)
        {
            rb.AddForce(Vector2.up * jumpingPower, ForceMode2D.Impulse);
            jumping = true;
        }
        if (rb.velocity.y == 0)
        {
            jumping = false;
        }

        if ((Input.GetKeyDown(KeyCode.Space)) || Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("isJumping", true);
        }else
        {
            animator.SetBool("isJumping", false);
        }

        if (rb.velocity.y > 0.5)
        {
            animator.SetBool("isFalling", true);
        }
        if (rb.velocity.y <= 0.5)
        {
            animator.SetBool("isFalling", false);
        }
    }
}
