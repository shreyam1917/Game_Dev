using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bird_mvmnt : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpspeed;
    public GameObject CollidePanel;
    float x, y;
    public float Hmin, Hmax;
    public TMP_Text score_text;
    int score_value = 0;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = score_value.ToString();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);
        }
        transform.position = new Vector2(Mathf.Clamp(transform.position.x , Hmin, Hmax) , transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag== "Obstacle" )
        {
            Time.timeScale = 0;
            CollidePanel.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Points")
        {
           // other.gameObject.SetActive(true);
            score_value++;
        }
    }
}
