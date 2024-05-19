using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //add a method to verify if the image is being hovered
    public void OnMouseEnter()
    {
        //change image color to red, it is an image, not a sprite
        GetComponent<UnityEngine.UI.Image>().color = Color.red;
    }
}
