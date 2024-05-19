using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCtrl : MonoBehaviour
{
    
    public float movSpeed;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        float input = Input.GetAxisRaw("Horizontal");
        float newSpeedX = input * movSpeed;

        if (input > 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (input < 0)
        {
            spriteRenderer.flipX = false;
        }

        rb.velocity = new Vector2(newSpeedX, 0);
    }
}
