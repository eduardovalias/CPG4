using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float speed = 5.0f;
    private bool moveRight = false;
    private bool canMove = true;
    private float interactionDistance = 3.0f;
    public Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, playerTransform.position) < interactionDistance)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                moveRight = !moveRight;
                canMove = true;
            }
        }

        if (canMove)
        {
            if (moveRight)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        canMove = false;
    }
}
