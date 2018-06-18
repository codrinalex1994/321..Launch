using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour {
    public Color[] colors = new Color[4];
    private int colorIt = 0;

    public float duration = 3.0F;
    private bool swapColor = false;

    private Color mainColor1;
    private Color mainColor2;
    private float t;

    Camera cam;

    void Start()
    {
        ShuffleColors();
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        mainColor1 = colors[colorIt];
        NextColor();
        mainColor2 = colors[colorIt];
        NextColor();
    }

    void Update()
    {
        t = Mathf.PingPong(Time.time, duration) / duration;
        cam.backgroundColor = Color.Lerp(mainColor1, mainColor2, t);
        if(t>0.99f && !swapColor)
        {
            mainColor1 = colors[colorIt];
            NextColor();
            swapColor = true;
        }
        if(t<0.01f && swapColor)
        {
            mainColor2 = colors[colorIt];
            NextColor();
            swapColor = false;
        }
    }

    void NextColor()
    {
        colorIt = (colorIt + 1) % colors.Length;
        //Debug.Log("color: " + colorIt);
    }

    void ShuffleColors()
    {
        for(int positionOfArray = 0; positionOfArray < colors.Length; positionOfArray ++)
        {
            Color c = colors[positionOfArray];
            int randomPosition = Random.Range(0, colors.Length - 1);
            colors[positionOfArray] = colors[randomPosition];
            colors[randomPosition] = c;
        }
    }
}
