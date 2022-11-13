using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject gamobject;
    public GameObject winingtxt;
    public GameObject gameovertxt;
    public GameObject nextlevel;
    /*public GameObject prefab;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public Transform spawnpoint;
    public Transform spawnpoint2;
    public Transform spawnpoint3;
    public Transform spawnpoint4;*/



    public float speed;

    public float jump;
    public Rigidbody rb;
    float x, y, z;
   // float timer;
    void Start()

    {
        Time.timeScale = 1;
        /*var clone1 = Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);
        var clone2 = Instantiate(prefab, spawnpoint2.position, spawnpoint2.rotation);
        var clone3 = Instantiate(prefab, spawnpoint3.position, spawnpoint3.rotation);
        var clone4 = Instantiate(prefab, spawnpoint4.position, spawnpoint4.rotation);
        Destroy(clone1, 2f);
        Destroy(clone4, 2f);
        Destroy(clone2, 2f);
        Destroy(clone3, 2f);*/
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        y = Input.GetAxis("Jump");
        rb.velocity = new Vector3(x * speed,rb.velocity.y ,z * speed);
        rb.AddForce(y * jump * transform.up);
        

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            //gameObject.SetActive(false);
            /*if Time.timeScale=0 then game will pause 
             And if Time.timeScale= 1 game will resume 
            and if Time.timeScale= 0.5f game will run on slow motion */
            gameovertxt.SetActive(true);
            Time.timeScale = 0;
           
            
        }
        if (collision.gameObject.tag == "clone")
        {
            Destroy(collision.gameObject);
            gameovertxt.SetActive(true);
            Time.timeScale = 0;

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "win")
        {
            winingtxt.SetActive(true);
            nextlevel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
