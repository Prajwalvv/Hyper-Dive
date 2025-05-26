using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    private float timeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    public static spawner instanceSpawn;
    private void Awake()
    {
        instanceSpawn = this;
    }
    private void Update()
    {
        StartSpawning();
    }
    public void StartSpawning()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = StartTimeBtwSpawn;
            if (StartTimeBtwSpawn > minTime)
            {
                StartTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
