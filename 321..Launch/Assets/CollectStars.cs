﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStars : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger on");
        if (other.tag == "Star")
        {
            Debug.Log("Star collected!");
            Destroy(other.gameObject);
        }
    }
}
