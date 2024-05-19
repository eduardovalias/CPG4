using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject canvas;
    public GameObject interact;
    public GameObject shop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, playerTransform.position) < 3.0f)
        {
            //change sprite color to blink between white and black
            GetComponent<SpriteRenderer>().color = Color.Lerp(Color.white, Color.gray, Mathf.PingPong(Time.time, 1));
            interact.SetActive(true);

            
            if(Input.GetKeyDown(KeyCode.X))
            {
                shop.SetActive(true);
            }
        }
        else
        {
            //change sprite color to white
            GetComponent<SpriteRenderer>().color = Color.white;
            interact.SetActive(false);
        }
    }
}
