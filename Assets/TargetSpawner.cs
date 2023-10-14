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
        InvokeRepeating("SpawnTarget", 0f, spawnInterval);
    }

    void SpawnTarget() {
        float x = Random.Range(Camera.main.transform.position.x - Camera.main.orthographicSize,
        Camera.main.transform.position.x + Camera.main.orthographicSize);

        float y = Random.Range(Camera.main.transform.position.y - Camera.main.orthographicSize,
        Camera.main.transform.position.y + Camera.main.orthographicSize);

        Vector3 spawnPosition = new Vector3(x, y, 1);
        GameObject newTarget = Instantiate(targetPrefab, spawnPosition, Quaternion.identity);
        Destroy(newTarget, targetLifetime);
    }
}
