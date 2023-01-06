using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Spawnpoint : MonoBehaviour
{
    public GameObject Fire;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var clone = Instantiate(Fire, transform.position, Quaternion.identity);
            Destroy(clone, 2f);
        }

    }
}
