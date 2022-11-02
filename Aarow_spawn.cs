using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aarow_spawn : MonoBehaviour
{

    public GameObject Aarow;
    float counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            if (counter > 1)
            {
                var clone = Instantiate(Aarow, transform.position, Quaternion.identity);
                Destroy(clone, 2f);
                counter = 0;
            }

        }
        counter += Time.deltaTime;
    }
}