using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour {

    public GameObject asteroid;

    public float minX = -2.0f;
    public float maxX = 2.0f;

    public float minS = 2f;
    public float maxS = 7f;

    private float spawnSec;
    private float currentTime;

    private int countAsteroids;
    public float spawnAsteroidTime = 1f;

    // Use this for initialization
    void Start () {
        currentTime = Time.time;
        spawnSec = Random.Range(minS, maxS);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - currentTime > spawnSec)
        {
            StartCoroutine("SpawnAsteroids");
            
            currentTime = Time.time;
            spawnSec = Random.Range(minS, maxS);
            //Debug.Log("next spawn : " + spawnSec);
        }
    }

    IEnumerator SpawnAsteroids()
    {
        countAsteroids = (int)Random.Range(1f, 6f);
        for (int i = 0; i < countAsteroids; ++i)
        {
            Vector3 position = new Vector3(Random.Range(minX, maxX), transform.position.y, 0);
            Instantiate(asteroid, position, Quaternion.identity);
            yield return new WaitForSeconds(spawnAsteroidTime);
        }
    }
}
