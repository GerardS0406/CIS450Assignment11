/*
 * Gerard Lamoureux
 * ScoreManager
 * Assignment 11
 * Handles the score and the text
 */

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void IncrementScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
