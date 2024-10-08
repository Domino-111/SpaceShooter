using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid;
    public Transform pointA, pointB;
    public float timer;
    public float resetTime;

    void Start()
    {
        timer = resetTime;
    }
    
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Spawn();

            if (resetTime > .3f)
            {
                resetTime -= .1f;
            }
            
            timer = resetTime;
        }
    }

    void Spawn()
    {
        Vector3 pos = Vector3.Lerp(pointA.position, pointB.position, Random.Range(0f, 1f));

        Instantiate(asteroid, pos, Quaternion.identity);
    }
}
