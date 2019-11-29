using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//guns objects in 'Player's' hierarchy
[System.Serializable]
public class Guns
{
    public GameObject centralGun;
    [HideInInspector] public ParticleSystem  centralGunVFX; 
}

public class PlayerShooting : MonoBehaviour
{
    public float fireRate;
    public GameObject projectileObject;
    public float nextFire;
    public Guns guns;
    
  
    private void Start()
    {
        guns.centralGunVFX = guns.centralGun.GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Time.time > nextFire)
            {
                Instantiate(projectileObject, guns.centralGun.transform.position, Quaternion.Euler(Vector3.zero));
                guns.centralGunVFX.Play();

                nextFire = Time.time + 1 / fireRate;
            }
        }
    }
}
   
