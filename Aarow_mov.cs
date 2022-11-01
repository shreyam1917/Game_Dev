using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aarow_mov : MonoBehaviour
{
    public float aarow_speed;
    public Rigidbody2D aarow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + aarow_speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Animal")
        {
            Boat_mov.score_value++;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
