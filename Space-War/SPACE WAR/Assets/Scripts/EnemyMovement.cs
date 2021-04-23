using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 velocity;
    public static Vector3 playerVelocity = Vector3.up;

    // Update is called once per frame
    void Update()
    {
        transform.position -= playerVelocity * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }

}
