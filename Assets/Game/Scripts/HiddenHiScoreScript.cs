using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HiddenHiScoreScript : MonoBehaviour
{
    public int playerScoreX;
    public Text scoreTextX;
    public int HighestX;
    public Text highestTextX;




    public void addScore(int scoreToAdd)
    {
        playerScoreX = playerScoreX + scoreToAdd;
        scoreTextX.text = "Score: " + playerScoreX.ToString();
        if (HighestX < playerScoreX)
            PlayerPrefs.SetInt("HighestX", playerScoreX);
    }

    void Start()
    {
        HighestX = PlayerPrefs.GetInt("HighestX", 0);
        scoreTextX.text = "Score: " + playerScoreX.ToString();
        highestTextX.text = "Highest: " + HighestX.ToString();
    }

    void Update()
    {
        if (playerScoreX > HighestX)
        {
            HighestX = playerScoreX;
        }
        highestTextX.text = "Highest: " + HighestX.ToString();
    }


}
