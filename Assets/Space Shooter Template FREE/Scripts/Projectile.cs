using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public bool enemyBullet;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (enemyBullet && col.tag == "Player") 
        { 
                Destroy(gameObject);
        }
        else if (!enemyBullet && col.tag == "Enemy")
        {
                Destroy(gameObject);
        }
    }

    public void Update()
    {
        if(transform.position.y>10 || transform.position.y < -3)
        {
            Destroy(gameObject);
        }
    }

    
}


