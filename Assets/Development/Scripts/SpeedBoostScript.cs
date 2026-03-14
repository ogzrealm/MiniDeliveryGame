using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpeedBoostScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RandomRotation();
    }

    private void RandomRotation()
    {
        var randRotation = Random.Range(0, 360)*Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, randRotation));
    }
    
}
