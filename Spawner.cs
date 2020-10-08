using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject platformPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(platformPrefab, transform);
        Instantiate(platformPrefab, new Vector3(-5, 5, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
