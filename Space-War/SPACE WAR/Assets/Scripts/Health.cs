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
    public static int enemyCount = 0;
    public static int enemyKilled = 0;

    public void Start()
    {
        if (isEnemy)
            enemyCount++;
        if (!isEnemy)
        {
            maxHealth = PlayerPrefs.GetInt("HealthItem") * 10 + 100;
            health = maxHealth;
        }
    }

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
        if(isEnemy)
            enemyKilled++;
        if (!isEnemy)
            GameObject.FindGameObjectWithTag("GameOverPanel").SetActive(true);
        Destroy(gameObject);
    }
}
