using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Script : MonoBehaviour
{
    public GameObject Car_entry_Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Car_entry_Button.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Car_entry_Button.SetActive(false);

        }
    }
}
