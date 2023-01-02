using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Forest_Player_Mov : MonoBehaviour
{
    public float speed = 20f; // The speed at which the player runs
    public float tiltSensitivity = 6f; // The sensitivity of the tilt controls
    public float leftBoundary = -5f; // The left boundary of the player's movement
    public float rightBoundary = 5f; // The right boundary of the player's movement
    public TMP_Text forest_score_text;
    public float jumpForce = 35f; // The amount of force applied to the player when jumping
    public static int Forest_score_value = 0;
    private Rigidbody rb;
    public Image healthbar;
    public GameObject GameOverPanel;
    public AudioSource coincollection;
    public AudioSource Obcollision;
    public static bool isGrounded = true;
    public Animator anim;
    //public static int city_score_value;

    private void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Move the player forward
        transform.position += Vector3.forward * speed * Time.deltaTime;

        // Move the player left or right based on the phone tilt
        float tiltDelta = Input.acceleration.x * tiltSensitivity * Time.deltaTime;
        Vector3 newPos = transform.position + Vector3.right * tiltDelta;

        // Constrain the player's movement within the specified boundaries
        newPos.x = Mathf.Clamp(newPos.x, leftBoundary, rightBoundary);
        transform.position = newPos;

        // Check for swipe up input
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // If the touch started at the bottom half of the screen, jump
            if (Input.GetTouch(0).position.y < Screen.height / 2)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                anim.SetBool("is_jumping", true);
            }
        }
        else
        {
            anim.SetBool("is_jumping", false);
        }

        //score update
        forest_score_text.text = Forest_score_value.ToString();
        /* if (healthbar.fillAmount <= 0)
         {
             Time.timeScale = 0;
             GameOverPanel.SetActive(true);
         }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Points_Forest")
        {
            other.gameObject.SetActive(false);
            Forest_score_value++;
            coincollection.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OB_Forest")
        {
            healthbar.fillAmount -= 0.1f;
            Obcollision.Play();
            if (healthbar.fillAmount <= 0)
            {
                Time.timeScale = 0;
                GameOverPanel.SetActive(true);
            }
        }
    }
}
