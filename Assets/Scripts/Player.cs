using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Vector3 vel;

        vel = transform.right * Input.GetAxisRaw("Horizontal");
        vel += transform.forward * Input.GetAxisRaw("Vertical");

        rb.AddForce(vel * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Asteroids")
        {
            Destroy(gameObject);
        }
    }
}
