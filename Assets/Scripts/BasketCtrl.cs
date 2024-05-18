using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCtrl : MonoBehaviour
{
    
    public float movSpeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float newSpeedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        
        rb.velocity = new Vector2(newSpeedX, 0);
    }
}
