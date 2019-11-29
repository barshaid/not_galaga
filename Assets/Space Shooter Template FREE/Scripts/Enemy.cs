using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject destructionVFX;
    public GameObject hitEffect;

    public float shotRate;

    public void Start()
    {
        shotRate = Time.time + (float)Random.Range(1, 15);
    }
    private void Update()
    {
        if(Time.time > shotRate)
        {
            shotRate = Time.time + (float)Random.Range(1, 15);
            Instantiate(Projectile, gameObject.transform.position, Quaternion.identity);
        }
    }
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Player_Short_Lazer(Clone)")
        {
            Instantiate(destructionVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }


    }
}