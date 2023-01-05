using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_mov : MonoBehaviour
{
    public float shoot_speed;
    public Rigidbody2D Fire;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + shoot_speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Obstacle")
        {
            Spaceship_mov.score_value++;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
