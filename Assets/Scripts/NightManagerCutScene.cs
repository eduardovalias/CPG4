using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NightDayManagerCutScene : MonoBehaviour
{
    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
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
