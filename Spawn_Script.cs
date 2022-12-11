using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Script : MonoBehaviour
{
    public GameObject prefab;
    public GameObject SpawnPoint;
    float timer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        /*var clone = Instantiate(prefab , SpawnPoint.transform.position , Quaternion.identity );
        Destroy(clone, 5f);*/
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>1.8f)
        {
            var clone = Instantiate(prefab , SpawnPoint.transform.position, Quaternion.identity);
            Destroy(clone, 9f);
            timer = 0;
        }
    }
}
