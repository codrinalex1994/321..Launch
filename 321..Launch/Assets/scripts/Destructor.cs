using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destructor : MonoBehaviour {

    public Button restartButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            restartButton.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
