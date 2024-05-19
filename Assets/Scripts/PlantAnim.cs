using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantAnim : MonoBehaviour
{
    [SerializeField] private Animator myAnim;   
    [SerializeField] private string plantGrow = "Plant_Grow";
    [SerializeField] private float delay = 2.0f;

    public GameObject canvas;

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
}
