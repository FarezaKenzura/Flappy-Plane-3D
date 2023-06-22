using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreManager
{
    private static int score;
    public static int Score
    {
        get {return score;}
    }
    public static void AddScore(int value)
    {
        score += value;
    }

    public static void ResetScore()
    {
        score = 0;
    }
}
