using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    float speed;
    public float topSpeed, bottomSpeed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = Random.Range(bottomSpeed, topSpeed);

        Vector3 rot;
        rot.x = Random.Range(-20f, 20f);
        rot.y = Random.Range(-20f, 20f);
        rot.z = Random.Range(-20f, 20f);

        rb.AddTorque(rot);

        transform.localScale = Vector3.one * Random.Range(1f,3f);

        Destroy(gameObject, 10);
    }

    
    void Update()
    {
        rb.AddForce(Vector3.back * Time.deltaTime * speed);
    }
}
