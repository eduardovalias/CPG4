using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NightMinigameManager : MonoBehaviour
{
    public TMP_Text neutralizedText;
    public TMP_Text initialText;
    public StrawberryNight prefab;
    public ZeMorangoNightCtrl ze;
    public float spawnInterval = 1f;
    public int fruitsNumber;
    public int neutralized = 0;
    public float spawnX1 = -0.28f;
    public float spawnX2 = 3.5f;
    public float spawnX3 = 8.47f;
    private float timePassed = 0f;
    private int fruitsSpawnCount = 0;
    private bool gameOver = false;
    private bool gameStart = false;

    void Start()
    {
        fruitsNumber = GameManager.straw;
        StartCoroutine(CloseInitialTxtCoroutine());
    }

    void Update()
    {
        if (gameOver)
        {
            return;
        }

        if (!gameStart)
        {
            return;
        }

        timePassed += Time.deltaTime;
        if (timePassed > spawnInterval)
        {
            InstantiateFruit();

            if (fruitsSpawnCount == fruitsNumber)
            {
                gameOver = true;
                GameManager.straw = neutralized;
                StartCoroutine(GameOverCoroutine());
            }

            timePassed = 0;
        }
    }

    void InstantiateFruit()
    {
        fruitsSpawnCount++;

        var position = new Vector3(getXSpawnPosition(), 8, 0);
        var fruit = Instantiate(prefab, position, Quaternion.identity);
        fruit.movSpeed = Random.Range(5, 10);
    }

    float getXSpawnPosition()
    {
        float r = Random.Range(0, 3);
        if (r < 1)
        {
            return spawnX1;
        }
        else if (r < 2)
        {
            return spawnX2;
        }
        return spawnX3;
    }

    public void IncreaseNeutralized()
    {
        neutralized++;
        UpdateNeutralizedText();
    }

    void UpdateNeutralizedText()
    {
        neutralizedText.text = $"x{neutralized}";
    }

    IEnumerator CloseInitialTxtCoroutine()
    {
        yield return new WaitForSeconds(3);
        initialText.enabled = false;
        gameStart = true;
    }

    IEnumerator GameOverCoroutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Day");
    }
}
