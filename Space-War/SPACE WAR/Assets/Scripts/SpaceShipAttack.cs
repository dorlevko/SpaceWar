using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipAttack : MonoBehaviour
{
    public float shootingRate = 0.5f;
    public float shootingPower = 15f;
    public float shootingAccu = 1f;
    float shootingTimer = 0f;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Input.simulateMouseWithTouches = true;
    }

    // Update is called once per frame
    void Update()
    {
        shootingTimer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (shootingTimer > shootingRate)
            {
                Shoot();
                shootingTimer = 0f;
            }
        }
    }

    void Shoot()
    {
        GameObject g = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = g.GetComponent<Rigidbody>();
        rb.velocity += Vector3.up * shootingPower;
    }
}
