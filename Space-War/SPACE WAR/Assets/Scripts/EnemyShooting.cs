using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform gun;
    public float shootingDelay = 1f;
    public GameObject bulletPrefab;
    public float shootingPower = 8f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0, shootingDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        GameObject g = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = g.GetComponent<Rigidbody>();
        rb.velocity += gun.forward * shootingPower;
    }
}
