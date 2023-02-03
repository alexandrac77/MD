using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Collectibles : MonoBehaviour
{
    private int collectCounter = 0;
    [SerializeField] private TMP_Text scoreText;
    public string HighScore;
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.gameObject.CompareTag("Chocolate"))
        {
            Destroy(collision.gameObject);
            collectCounter++;
            // Debug.Log("chocolate: " + collectCounter);
            scoreText.text = "Chocolate: " + collectCounter;
            HighScore = scoreText.text;
        }
    }
}
