using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fruit : MonoBehaviour
{

    public CatchFruitManager manager;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = (CatchFruitManager) FindObjectOfType(typeof(CatchFruitManager));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag == "basket"){
            manager.scoreCatchFruit++;
        } 
        Destroy(this.gameObject);
    }
}
