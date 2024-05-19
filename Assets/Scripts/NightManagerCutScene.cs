using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NightDayManagerCutScene : MonoBehaviour
{
    public string nextScene;
    public TMP_Text coinsTxt;

    // Start is called before the first frame update
    void Start()
    {
        if (nextScene == "SampleScene")
        {
            GameManager.coins += GameManager.straw * 2;
            GameManager.straw = 0;
        }

        if (coinsTxt != null)
        {
            coinsTxt.text = $"+{GameManager.coins}";
        }

        StartCoroutine(LoadMinigameCoroutine());
    }

    IEnumerator LoadMinigameCoroutine()
    {
        yield return new WaitForSeconds(3f);

        // gambiarra a vista:
        if (nextScene == "NightMinigame" && GameManager.straw == 0) {
            
        SceneManager.LoadScene("Day");
        }
        else
        {
        SceneManager.LoadScene(nextScene);
        }
    }
}
