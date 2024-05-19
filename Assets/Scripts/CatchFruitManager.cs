using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CatchFruitManager : MonoBehaviour
{
    public GameObject fruitPrefab;
    public TMP_Text scoreText;
    public TMP_Text initialTxt;

    public float fruitSpawnPositionYOffset = 8F;
    public float fruitSpawnPositionXMinRange = -8F;
    public float fruitSpawnPositionXMaxRange = 8F;
    public float fruitGravityScaleMinRange = 3F;
    public float fruitGravityScaleMaxRange = 5F;
    public int fruitsNumber = 10;
    public float fruitSpawnIntervalReduceFactor = 0.1f;
    public float fruitInicialSpawnInterval = 2f;
    public static int collected = 0;

    private float curFruitSpawnInterval;

    private float timePassed = 0F;
    private int fruitsSpawnCount = 0;


    private bool gameOver = false;


    void Start()
    {
        curFruitSpawnInterval = fruitInicialSpawnInterval;
        StartCoroutine(CloseInitialTxtCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            return;
        }

        timePassed += Time.deltaTime;
        if (timePassed > curFruitSpawnInterval)
        {
            InstantiateFruit();

            if (fruitsSpawnCount == fruitsNumber)
            {
                gameOver = true;
                StartCoroutine(GameoverCoroutine());
            }
            else
            {
                curFruitSpawnInterval -= fruitSpawnIntervalReduceFactor;
            }

            timePassed = 0;
        }
    }

    void InstantiateFruit()
    {
        fruitsSpawnCount++;

        var position = new Vector3(Random.Range(fruitSpawnPositionXMinRange, fruitSpawnPositionXMaxRange), fruitSpawnPositionYOffset, 0);
        var fruit = Instantiate(fruitPrefab, position, Quaternion.identity);

        var rb = fruit.GetComponentInChildren<Rigidbody2D>();
        var gravityOffset = 0.2f * fruitsSpawnCount;

        rb.gravityScale = Random.Range(fruitGravityScaleMinRange + gravityOffset, fruitGravityScaleMaxRange + gravityOffset);
    }


    public void IncreaseCollected()
    {
        collected++;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = $"x{collected}";
    }

    IEnumerator CloseInitialTxtCoroutine()
    {
        yield return new WaitForSeconds(3);
        initialTxt.enabled = false;
    }

    IEnumerator GameoverCoroutine()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("SampleScene");
    }
}
