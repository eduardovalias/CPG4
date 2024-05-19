using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public Button btnPlant1;
    public Button btnPlant2;
    public Button btnPlant3;
    public Button btnPlant4;
    public GameObject canvas;
    public TMP_Text strawTxt;
    public TMP_Text coinTxt;
    public static int coins;
    public static int straw;
    public static bool sceneStartedOnce;
    public static bool isPlanted1;
    public static bool isPlanted2;
    public static bool isPlanted3;
    public static bool isPlanted4;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sceneStartedOnce);
            Debug.Log(coins);
        if(!GameManager.sceneStartedOnce)
        {
            coins = 50;
            sceneStartedOnce = true;
        }
        strawTxt.text = $"Morangos: {straw}";
        coinTxt.text = $"Moedas: {coins}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void Plant(int terrain)
    {
        if(terrain == 1)
        {
            btnPlant1.interactable = false;
            isPlanted1 = true;
        }
        else if(terrain == 2)
        {
            btnPlant2.interactable = false;
            isPlanted2 = true;
        }
        else if(terrain == 3)
        {
            btnPlant3.interactable = false;
            isPlanted3 = true;
        }  
        else if(terrain == 4)
        {
            btnPlant4.interactable = false;
            isPlanted4 = true;
        }

            coinTxt.text = $"Moedas: {ShopManagerCtrl.shopCoins}";
    }

    public bool IsPlanted(int terrain)
    {
        if(terrain == 1)
        {
            return isPlanted1;
        }
        else if(terrain == 2)
        {
            return isPlanted2;
        }
        else if(terrain == 3)
        {
            return isPlanted3;
        }
        else if(terrain == 4)
        {
            return isPlanted4;
        }
        return false;
    }

    public void RemovePlant(int terrain)
    {
        if(terrain == 1)
        {
            btnPlant1.interactable = true;
            isPlanted1 = false;
        }
        else if(terrain == 2)
        {
            btnPlant2.interactable = true;
            isPlanted2 = false;
        }
        else if(terrain == 3)
        {
            btnPlant3.interactable = true;
            isPlanted3 = false;
        }
        else if(terrain == 4)
        {
            btnPlant4.interactable = true;
            isPlanted4 = false;
        }
    }

    public void ExitMenu()
    {
        ShopManagerCtrl.shopCoins += ShopManagerCtrl.price;
        canvas.SetActive(false);
    }
}
