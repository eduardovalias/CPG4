using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    Vector2 velocity;
    public float smoothTime = 0.15F;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        float newSpeedX = Horizontal * movSpeed;
        float newSpeedY = Vertical * movSpeed;
        
        speedX = Mathf.SmoothDamp(speedX, newSpeedX, ref velocity.x, smoothTime);
        speedY = Mathf.SmoothDamp(speedY, newSpeedY, ref velocity.y, smoothTime);
        
        rb.velocity = new Vector2(speedX, speedY);
    }
}
