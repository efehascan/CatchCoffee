using System.Collections;
using UnityEngine;

public class FruitSpawnerScript : MonoBehaviour
{
    public GameObject[] fruits;
    public float sabitY = 10f;
    public float SpawnSuresi = 1.0f;
    
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }
    
    void Update()
    {
        
        
    }

    IEnumerator SpawnFruits()
    {
        while(true)
        {
            int randomFruit = Random.Range(0, fruits.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-10f, 10f), sabitY, Random.Range(-10f, 10f));
            
            Instantiate(fruits[randomFruit], spawnPos, Quaternion.identity);
            
            yield return new WaitForSeconds(SpawnSuresi);
        }
    }
}