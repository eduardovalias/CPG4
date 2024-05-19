using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberryNight : MonoBehaviour
{
    public float movSpeed = 5;
    Rigidbody2D rb;
    public NightMinigameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = (NightMinigameManager)FindObjectOfType(typeof(NightMinigameManager));
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, movSpeed * -1);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "basket")
        {
            manager.IncreaseNeutralized();
        }
        Destroy(this.gameObject);
    }
}
