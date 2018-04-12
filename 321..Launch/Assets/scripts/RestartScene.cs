using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class RestartScene : MonoBehaviour {

    public Button restartButton;

    public void RestartGame()
    {
        ScoreUI.score = 0;
        Time.timeScale = 1;
        restartButton.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
