using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10;
    public bool isEnemy = true;
    public GameObject spawnOnDestroy;

    void OnCollisionEnter(Collision collision)
    {
        Health otherHealth = collision.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            if (otherHealth.isEnemy != isEnemy)
            {
                otherHealth.Damage(damage);
            }
        }

        if (spawnOnDestroy != null)
        {
            Instantiate(spawnOnDestroy, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
