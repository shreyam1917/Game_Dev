using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_mov : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset_distance;
    void Start()
    {
        offset_distance = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset_distance;  
    }
}
