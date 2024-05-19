using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    Vector2 velocity;
    public float smoothTime = 0.15F;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float newSpeedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        float newSpeedY = Input.GetAxisRaw("Vertical") * movSpeed;
        
        speedX = Mathf.SmoothDamp(speedX, newSpeedX, ref velocity.x, smoothTime);
        speedY = Mathf.SmoothDamp(speedY, newSpeedY, ref velocity.y, smoothTime);
        
        rb.velocity = new Vector2(speedX, speedY);

        spriteRenderer.flipX = rb.velocity.x > 0f;
    }
}
