using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class PointSystem : MonoBehaviour
{

    public static int score;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AddScore(1);
            Destroy(this.gameObject);
        }

     
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Terrain"))
        {
            Destroy(this.gameObject,1.5f);
        }   
    }

    void AddScore(int points)
    {
        GameManager.GameManagerInstance.AddScore();
    }
    
}
