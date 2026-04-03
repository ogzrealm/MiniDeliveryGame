using UnityEngine;
using System.Collections.Generic;

public class ClockSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject boostItem;
    [SerializeField] private List<Transform> SpawnPoints;
    private float _lastSpawnPoint;
    
    private void Start()
    {
        RandomClockRandomSpawn();
    }
    
    public void RandomClockRandomSpawn()
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
