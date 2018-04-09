using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour {
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;
    private bool useOneColor = false;
    private float t;

    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
        t = Mathf.PingPong(Time.time, duration) / duration;
        if (t > 0.99f)
            useOneColor = true;
        if (!useOneColor)
            cam.backgroundColor = Color.Lerp(color1, color2, t);
        else
            cam.backgroundColor = color2;
    }
}
