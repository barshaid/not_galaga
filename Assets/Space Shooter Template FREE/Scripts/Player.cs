using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public GameObject destructionVFX;

    private void Update()
    {
        if (!GameObject.FindGameObjectWithTag("Enemy"))
        {
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Enemy_Straight_Projetile(Clone)" || col.tag=="Enemy")
        {
            Instantiate(destructionVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Time.timeScale = 0;
        }


    }
}
















