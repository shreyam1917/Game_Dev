using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boat_mov : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    float x, y;
    public float Wmin, Wmax;
    public TMP_Text score_text;
    public static int score_value = 0;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score_value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, Wmin, Wmax), transform.position.y);

        score_text.text = score_value.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Animal")
        {

            Destroy(gameObject);
            Time.timeScale = 0;
            Panel.SetActive(true);

        }
    }
}
