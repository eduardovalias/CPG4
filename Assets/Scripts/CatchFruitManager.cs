using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFruitManager : MonoBehaviour
{

    public float fruitInterval = 2F;

    float curFruitInterval;

    float timePassed = 0F;

    public GameObject fruitPrefab;
    public float gravityScaleMinRange = 3F;
    public float gravityScaleMaxRange = 5F;

    public float positionXMinRange = -8F;
    public float positionXMaxRange = 8F;
    
    public int scoreCatchFruit = 0;
    public bool gameOver = false;

    float intervalIncreaseCounter = 0;

    void Start()
    {
        curFruitInterval = fruitInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if(timePassed > curFruitInterval && !gameOver) {
            if (curFruitInterval > 0.25f) {
                curFruitInterval -= 0.03f;
                intervalIncreaseCounter++;
            } else {
                gameOver = true;
            }

            timePassed = 0;
            InstantiateFruit();
        } 
    }

    void InstantiateFruit(){
        float gravityOffset = 0.2f * intervalIncreaseCounter;

        var fruit = Instantiate(fruitPrefab, new Vector3(Random.Range(positionXMinRange, positionXMaxRange),8,0), Quaternion.identity);
        fruit.GetComponentInChildren<Rigidbody2D>().gravityScale = Random.Range(gravityScaleMinRange + gravityOffset, gravityScaleMaxRange + gravityOffset);
    }

}
