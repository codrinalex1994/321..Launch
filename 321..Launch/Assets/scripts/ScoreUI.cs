using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public static int score;
    private Text uiText;
    private float lastUpdate;

	// Use this for initialization
	void Start () {
        uiText = GetComponent<Text>();
        lastUpdate = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        if(Time.time - lastUpdate >= 1f) {
            score += 1;
            lastUpdate = Time.time;
        }
        uiText.text = score.ToString();
	}
}
