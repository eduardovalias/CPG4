using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float velocity = 12f;

    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x += velocity * Time.deltaTime;
        transform.position = currentPosition;
    }
}
