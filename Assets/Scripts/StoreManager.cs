using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject storeUI;
    public GameObject canvas;
    public GameObject interact;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, playerTransform.position) < 3.0f)
        {
            //change sprite color to red
            GetComponent<SpriteRenderer>().color = Color.red;
            interact.SetActive(true);

            
            if(Input.GetKeyDown(KeyCode.X))
            {
                canvas.SetActive(true);
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
