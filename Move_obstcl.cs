using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_obstcl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x-speed, transform.position.y);
    }
}
