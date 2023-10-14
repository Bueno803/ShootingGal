using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public float spawnInterval = 5f;
    public float targetLifetime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", 0f; spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
