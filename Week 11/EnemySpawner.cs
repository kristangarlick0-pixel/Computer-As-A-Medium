using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemy2Prefab;

    private float timer = 0f;
    private float timer2 = 0f;

    void Start()
    {

    }

    void Update()
    {
        // Spawn first enemy every 2 seconds
        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
            timer = 0f;
        }

        // Spawn second enemy every 5 seconds
        timer2 += Time.deltaTime;

        if (timer2 >= 3f)
        {
            Instantiate(enemy2Prefab, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
            timer2 = 0f;
        }
    }
}
