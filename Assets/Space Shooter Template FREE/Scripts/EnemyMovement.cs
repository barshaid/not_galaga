using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour

{
    public float speed = 1f;
    public Borders borders;
    Camera mainCamera;
    Rigidbody2D ob;

    private void Start()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        ob = GetComponent<Rigidbody2D>();
        ob.velocity = new Vector2(speed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 2)
        {
            ob.velocity = new Vector2(-speed, 0);
        }
        else if (transform.position.x < -2)
        {
            ob.velocity = new Vector2(speed, 0);
        }

       
    }
}
