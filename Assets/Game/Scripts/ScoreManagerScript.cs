using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public int Highest;
    public Text highestText;



    
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = "Score: " + playerScore.ToString();
        if (Highest < playerScore)
            PlayerPrefs.SetInt("Highest", playerScore);
    }

    void Start()
    {
        Highest = PlayerPrefs.GetInt("Highest", 0);
        scoreText.text = "Score: " + playerScore.ToString();
        highestText.text = "Highest: " + Highest.ToString();
    }

    void Update()
    {
        if (playerScore > Highest)
        {
            Highest = playerScore;
        }
        highestText.text = "Highest: " + Highest.ToString();
    }
    

}
