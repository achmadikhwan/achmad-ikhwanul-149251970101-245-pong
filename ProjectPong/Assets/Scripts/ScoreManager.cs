using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int lScore;
    public int rScore;

    public int maxScore;
    public BallController ball;

    public void AddLeftScore(int increment)
    {
        lScore += increment;
        ball.ResetBall();

        if (lScore >= maxScore)
        {
            GameOver();
        }
    }

    public void AddRightScore(int increment)
    {
        rScore += increment;
        ball.ResetBall();
        if (rScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
        {
            SceneManager.LoadScene("Main Menu");
        }
    
}
