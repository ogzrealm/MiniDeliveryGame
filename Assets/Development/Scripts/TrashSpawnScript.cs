using System;
using UnityEngine;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class TrashSpawnScript : MonoBehaviour
{
    [SerializeField] private List<Transform> trashSpawn;
    [SerializeField] private GameObject trashPrefab;
    private int _lastSpawnPoint;

    private void Start()
    {
        RandomTrashSpawn();
    }
    

    private void RandomTrashSpawn()
    {
        
        for (int i = 0; i < 11; i++)
        {
            int randIndex = Random.Range(0, trashSpawn.Count);
            while (randIndex == _lastSpawnPoint)
            {
                randIndex = Random.Range(0, trashSpawn.Count);
            }
            GameObject trash=Instantiate(trashPrefab, trashSpawn[randIndex].position, trashSpawn[randIndex].rotation);
            trash.transform.SetParent(trashSpawn[randIndex]);
            _lastSpawnPoint = randIndex;
            
        }
    }

    public void SingleTrashSpawn()
    {
        int randIndex = Random.Range(0, trashSpawn.Count);
        GameObject singleTrash = Instantiate(trashPrefab, trashSpawn[randIndex].position, Quaternion.identity);
        singleTrash.transform.SetParent(trashSpawn[randIndex]);
    }
}
