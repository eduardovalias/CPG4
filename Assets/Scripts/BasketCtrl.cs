using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCtrl : MonoBehaviour
{
    
    public float movSpeed;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
            
    }

    // Update is called once per frame
    void Update()
    {

        float input = Input.GetAxisRaw("Horizontal");
        float newSpeedX = input * movSpeed;

        if (input == 0)
        {
            animator.Play("IdleZeMorango");
        } else
        {
            animator.Play("RunningZeMorango");
            if (input > 0)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }

        rb.velocity = new Vector2(newSpeedX, 0);
    }
}
