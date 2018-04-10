using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreUI : MonoBehaviour {

    private Text uiText;
    private string highscore;

	// Use this for initialization
	void Start () {
        uiText = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("HighScore", 0).ToString();
        uiText.text = "HS : " + highscore;
    }
}
