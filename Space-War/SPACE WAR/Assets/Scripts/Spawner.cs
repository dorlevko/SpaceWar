using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Wave[] waves;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        for (int i = 0; i < waves.Length; i++)
        {
            for (int j = 0; j < waves[i].amount; j++)
            {
                Vector3 randomPos = transform.position + (Vector3)Random.insideUnitCircle * 2;
                GameObject objectToSpawn = waves[i].spawnerOptions[Random.Range(0, waves[i].spawnerOptions.Length)];
                Instantiate(objectToSpawn, randomPos,objectToSpawn.transform.rotation);
                yield return new WaitForSeconds(waves[i].spwanDelay);
            }
            yield return new WaitForSeconds(10f);
        }
    }

    
}

[System.Serializable]
public class Wave
{
    public GameObject[] spawnerOptions;
    public float spwanDelay;
    public int amount;
}
