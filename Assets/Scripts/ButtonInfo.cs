using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{

    public TMP_Text priceTXT;
    public int ItemID;
    public GameObject ShopManager;

    void Update()
    {
        priceTXT.text = "Price: " + ShopManager.GetComponent<ShopManagerCtrl>().shopItems[2, ItemID].ToString();
    }
}
