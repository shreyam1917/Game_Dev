using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject SpawnPoint;
    float timer = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1.5f)
        {
            var clone = Instantiate(prefabs[Random.Range(0, prefabs.Length - 1)], SpawnPoint.transform.position, Quaternion.identity);
            Destroy(clone, 5f);
            timer = 0;
        }
    }
}
