using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnpos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
       
    }
    void SpawnObstacle ()
    {
        Instantiate(obstaclePrefab, spawnpos, obstaclePrefab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
