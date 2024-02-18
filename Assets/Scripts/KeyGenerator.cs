using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] spawningKeys;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject canva;
    [SerializeField] private GameObject[] spawnPoints;

    public void SpawnKey()
    {
        
        int index = Random.Range(0, spawningKeys.Length);
        
        GameObject keyToBeSpawned = spawningKeys[index];
        MovingKey movingKey = keyToBeSpawned.GetComponent<MovingKey>();
        movingKey.Target = target;

        index = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[index].transform;
        
        GameObject key = Instantiate(keyToBeSpawned, spawnPoint);
    }
}
