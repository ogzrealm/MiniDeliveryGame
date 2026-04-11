using System.Collections.Generic;
using UnityEngine;

public class BoosterSpawnScript : MonoBehaviour
{
    [SerializeField] private List<Transform> SpawnPoints;
    [SerializeField] private GameObject boostItem;
    private int _lastSpawnPoint;
    
    private void Start()
    {
        RandomSpawn();
    }
    
    public void RandomSpawn()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Count);
        
        while (randomIndex == _lastSpawnPoint )
        {
            randomIndex = Random.Range(0, SpawnPoints.Count);
            
        }
        GameObject spawnItem = Instantiate(boostItem, SpawnPoints[randomIndex].position, SpawnPoints[randomIndex].rotation);
        _lastSpawnPoint = randomIndex;
    }
    
}
