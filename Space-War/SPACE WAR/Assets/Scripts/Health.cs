using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public bool isEnemy = true;
    public float health = 100;
    public float maxHealth = 100;
    public Image healthBar;
    public GameObject spawnOnDestroy;


    public void Damage(float amount)
    {
        health -= amount;
        if (healthBar != null)
        {
            healthBar.fillAmount = health / maxHealth;
        }

        if (health <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        if (spawnOnDestroy != null)
        {
            Instantiate(spawnOnDestroy, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
