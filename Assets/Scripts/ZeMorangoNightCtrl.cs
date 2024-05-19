using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZeMorangoNightCtrl : MonoBehaviour
{

    public float movSpeed;
    public int ammo;
    public GameObject bullet;
    public TMP_Text ammoText;
    Rigidbody2D rb;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        ammo = GameManager.straw;
        UpdateAmmoText();
    }

    // Update is called once per frame
    void Update()
    {

        float input = Input.GetAxisRaw("Vertical");
        float newSpeedY = input * movSpeed;

        rb.velocity = new Vector2(0, newSpeedY);


        if (Input.GetKeyDown(KeyCode.X) && ammo > 0)
        {
            var pos = transform.position;
            pos.x += 1;
            ammo--;
            animator.SetTrigger("shoot");
            Instantiate(bullet, pos, Quaternion.identity);
            UpdateAmmoText();
        }
     }

    void UpdateAmmoText()
    {
        ammoText.text = $"x{ammo}";
    }
}
