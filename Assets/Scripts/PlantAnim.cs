using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlantAnim : MonoBehaviour
{
    [SerializeField] private Animator myAnim;   
    [SerializeField] private string plantGrow = "Plant_Grow";
    [SerializeField] private float delay = 2.0f;
    public Transform playerTransform;
    public Transform plantTransform;
    public GameObject interact;
    public int plantNumber;
    public GameManager gameManager;

    public GameObject canvas;

    void Start()
    {
        if(gameManager.IsPlanted(plantNumber))
        {
            Grow();
        }
    }
    public void Grow()
    {
        canvas.SetActive(false);
        StartCoroutine(StartAnimationAfterDelay());
    }

    private IEnumerator StartAnimationAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        myAnim.Play(plantGrow, 0, 0.0f);
    }

    void Update()
    {
        if(Vector3.Distance(plantTransform.position, playerTransform.position) < 3.0f)
        {
            if(gameManager.IsPlanted(plantNumber))
            {
                interact.SetActive(true);

            
                if(Input.GetKeyDown(KeyCode.X))
                {
                    SceneManager.LoadScene("FruitMiniGameScene");
                    gameManager.RemovePlant(plantNumber);
                }
            }
        }
        else
        {
            interact.SetActive(false);
        }
        
    }
}
