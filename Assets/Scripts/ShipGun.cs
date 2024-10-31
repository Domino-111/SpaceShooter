using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipGun : MonoBehaviour
{
    public GameObject laser;
    public float shootSpeed = 300;
    public Transform firepoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootBullet();
        }
    }

    void shootBullet()
    {
        Instantiate(laser, firepoint.position, Quaternion.identity);
    }
}