using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f))
            {
                Vector3 aimDirection = hit - (Vector3)transform.position;


                float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

                Quaternion rotation = Quaternion.Euler(0, 0, angle);

                GameObject spawnedBullet = Instantiate(bullet, transform.position, rotation);
            }
        }
    }
}
