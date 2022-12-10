using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_script : MonoBehaviour
{
    public float speed;
    public Renderer bg;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        bg.material.mainTextureOffset = new Vector2(0, speed * Time.time);
    }
}
