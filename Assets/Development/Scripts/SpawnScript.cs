using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField] private List<Transform> SpawnPoints;
    [SerializeField] private GameObject boostItem;
    private GameObject spawnItem;
    private int _lastSpawnPoint;
    
    private void Start()
    {
        RandomSpawn();
    }
    
    public void RandomSpawn()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Count-1);
        while (randomIndex == _lastSpawnPoint)
        {
            randomIndex = Random.Range(0, SpawnPoints.Count);
        }
        spawnItem = Instantiate(boostItem, SpawnPoints[randomIndex].position, SpawnPoints[randomIndex].rotation);
        _lastSpawnPoint = randomIndex;
    }
    
}
