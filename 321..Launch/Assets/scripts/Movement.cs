using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class Movement : MonoBehaviour {

    public float speed = 5;
    private Rigidbody2D rb2d;
    public Boundary boundary;
    private bool onAndroid = true;

    private void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            onAndroid = true;
            speed *= 2;
        } else {
            onAndroid = false;
        }

        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 inputAccelerometer;
        float horizontal;

        if (onAndroid)
        {
            inputAccelerometer = Input.acceleration;
            horizontal = inputAccelerometer.x;
        } else {

            horizontal = Input.GetAxis("Horizontal");
        }
        
        Vector2 movement = new Vector2(horizontal,0.0f);
        rb2d.velocity = movement*speed;

        rb2d.position = new Vector2(Mathf.Clamp(rb2d.position.x,boundary.xMin,boundary.xMax),-4.0f);
    }
}
