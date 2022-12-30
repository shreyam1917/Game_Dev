using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class City_Player_Mov : MonoBehaviour
{
    public float speed = 20f;
    public float tiltSensitivity = 6f;
    public float leftBoundary = -5f;
    public float rightBoundary = 5f;
    public TMP_Text city_score_text;
    public float jumpForce = 35f;
    public static int City_score_value = 0;
    private Rigidbody rb;
    public Image healthbar;
    public GameObject GameOverPanel;
    public AudioSource coincollection;
    public AudioSource Obcollision;
    public static bool isGrounded = true;
    public Animator anim;
    private bool hasJumped = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;

        float tiltDelta = Input.acceleration.x * tiltSensitivity * Time.deltaTime;
        Vector3 newPos = transform.position + Vector3.right * tiltDelta;

        newPos.x = Mathf.Clamp(newPos.x, leftBoundary, rightBoundary);
        transform.position = newPos;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Input.GetTouch(0).position.y < Screen.height / 2  && !hasJumped)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                anim.SetBool("is_jumping", true);
                hasJumped = true;
            }
        }
        else
        {
            anim.SetBool("is_jumping", false);
        }

        city_score_text.text = City_score_value.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Points")
        {
            other.gameObject.SetActive(false);
            City_score_value++;
            coincollection.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OB")
        {
            healthbar.fillAmount -= 0.1f;
            Obcollision.Play();
            if (healthbar.fillAmount <= 0)
            {
                Time.timeScale = 0;
                GameOverPanel.SetActive(true);
            }  
        }
        if(collision.gameObject.tag == "ground")
        {
            hasJumped = false;
        }
    }
}
