using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public float speed = 20f;
    private float timeElapsed = 0f;

    public float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        transform.rotation = Quaternion.Euler(90f, 0, 0);
    }

    void Update()
    {
        rb.AddForce(transform.up * speed * Time.deltaTime);

        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Asteroids")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
