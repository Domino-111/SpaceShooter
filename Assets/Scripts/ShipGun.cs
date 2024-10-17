using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGun : MonoBehaviour
{
    public Rigidbody laser;
    public float shootSpeed = 300;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootBullet();
        }
    }

    void shootBullet()
    {
        // Instantiate a new bullet at the players position and rotation
        // later you might want to add an offset here or 
        // use a dedicated spawn transform under the player
        var projectile = Instantiate(laser, transform.position, transform.rotation);

        //Shoot the Bullet in the forward direction of the player
        projectile.velocity = transform.forward * shootSpeed;
    }
}