using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour
{
    public Transform playerTransform;
    public Transform doorTransform;
    public GameObject interact;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(doorTransform.position, playerTransform.position) < 1.0f)
        {
            interact.SetActive(true);

            
            if(Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("Eh o dormes");
            }
        }
        else
        {
            interact.SetActive(false);
        }
        
    }
}
