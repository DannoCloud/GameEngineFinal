using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingManager : MonoBehaviour
{
    public GameObject fallPrefab;

    private float spawnRangeX = 11.0f;
    private float Low = -2.5f;
    private float High = 6.0f;
    private float startDelay = 1.0f;
    private float spawnStep = 0.18f;
    




    // Start is called before the first frame update
    void Start()
    {


        for (int i = 0; i < 25; i++)  // when stated will make 25 steps 
        {
            Vector2 spawnDrop = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(Low, High));

            Instantiate(fallPrefab, spawnDrop, fallPrefab.transform.rotation);
        }

        InvokeRepeating("fallRandom", startDelay, spawnStep);

    }


    // Update is called once per frame
    void Update()
    {



    }






    public void fallRandom() // Spawns falling Step  
    {
        Vector2 spawnDrop = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), High);
        
        Instantiate(fallPrefab, spawnDrop, fallPrefab.transform.rotation);
    }

}
