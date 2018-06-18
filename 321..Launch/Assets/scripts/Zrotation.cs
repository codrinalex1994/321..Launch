using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zrotation : MonoBehaviour {

    public float speed = 60; 
    float z;
    
    void Update()
    {

        z += Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, 0, z);

    }
}
