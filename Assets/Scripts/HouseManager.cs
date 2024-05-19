using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseManager : MonoBehaviour
{
    public Transform playerTransform;
    public Transform doorTransform;
    public GameObject interact;
    public GameManager gameManager;
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
                SceneManager.LoadScene("Night");
            }
        }
        else
        {
            interact.SetActive(false);
        }
        
    }
}
