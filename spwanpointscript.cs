using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanpointscript : MonoBehaviour
{
    public GameObject prefab;
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            timer = 0;
            var clone = Instantiate(prefab, transform.position, transform.rotation);
            //here
            Destroy(clone, 2f);
           
        }
    }
}
