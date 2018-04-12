using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStar : MonoBehaviour {

    public GameObject star;

    public float minX = -2.0f;
    public float maxX = 2.0f;

    public float minS = 5f;
    public float maxS = 11f;

    private float spawnSec;
    private float currentTime;

    private void Start()
    {
        currentTime = Time.time;
        spawnSec = Random.Range(minS, maxS);
    }

    // Update is called once per frame
    void Update () {
		if (Time.time - currentTime > spawnSec)
        {
            Vector3 position = new Vector3(Random.Range(minX, maxX), transform.position.y, 0);
            Instantiate(star, position, Quaternion.identity);
            currentTime = Time.time;
            spawnSec = Random.Range(minS, maxS);
            //Debug.Log("next spawn : " + spawnSec);
        }
	}
}
