using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class KeyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] spawningKeys;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject[] spawnPoints;
    [FormerlySerializedAs("_scoreCounter")] [SerializeField] private ScoreCounter scoreCounter;

    public void SpawnKey()
    {
        
        int index = Random.Range(0, spawningKeys.Length);
        
        GameObject keyToBeSpawned = spawningKeys[index];
        
        MovingKey movingKey = keyToBeSpawned.GetComponent<MovingKey>();
        movingKey.Target = target;
        movingKey.ScoreCounter = scoreCounter;

        index = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[index].transform;
        
        GameObject key = Instantiate(keyToBeSpawned, spawnPoint);
    }
}
