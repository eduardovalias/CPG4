using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ShopManagerCtrl : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public float coins;
    public Text coinsTXT;


    void Start()
    {
        coinsTXT.text = $"{coins} coins";

        //ID's 
        shopItems[1,1] = 1; 
        shopItems[1,2] = 2; 
        shopItems[1,3] = 3; 
        shopItems[1,4] = 4; 

        //Price 
        shopItems[2,1] = 10; 
        shopItems[2,2] = 20; 
        shopItems[2,3] = 30; 
        shopItems[2,4] = 40; 
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID]){
            coins -= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID];
            coinsTXT.text = $"{coins} coins";
        }
    }
}
