using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;

    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0) {
	    int rand = Random.Range(0, obstaclePatterns.Length);
	    Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
	    timeBtwSpawn = startTimeBtwSpawn;
	    if (startTimeBtwSpawn > minTime) {
	        startTimeBtwSpawn -= decreaseTime;
	    }
	} else {
	    timeBtwSpawn -= Time.deltaTime;
	}
    }
}
