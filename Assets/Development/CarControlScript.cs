using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarControlScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;
    private float origiinalSpeed;
    private bool isSlowed = false;
    private IEnumerator dumpRoutine;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        origiinalSpeed = moveSpeed;
    }

    public void Moving(float moveValue)
    {
        Vector3 direction = Vector3.up * moveValue;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    public void Turning(float turnValue)
    {
        var turn = turnValue * turnSpeed;
        transform.Rotate(0,0,turn*Time.deltaTime);
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DumpTag"))
        {
            if (isSlowed && dumpRoutine != null)
            {
                StopCoroutine(dumpRoutine);
            }
            dumpRoutine = Slow();
            StartCoroutine(dumpRoutine);
        }
    }

    IEnumerator Slow()
    {
        moveSpeed=origiinalSpeed*0.5f;
        isSlowed = true;
        Debug.Log("Your Speed is Half");
        
        yield return new WaitForSeconds(1.5f);
        
        isSlowed = false;
        moveSpeed = origiinalSpeed;
        Debug.Log("Your Speed is Normal");
        dumpRoutine = null;
        
    }
    
    
}
