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
        int earned = 0;
        if (nextScene == "SampleScene")
        {

            earned = GameManager.straw * 2;
            GameManager.coins += earned;
            GameManager.straw = 0;
        }

        if (coinsTxt != null)
        {
            coinsTxt.text = $"+{earned}";
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
