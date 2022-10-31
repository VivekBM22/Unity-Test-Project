using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreManager
{
    public const int MAX_HEALTH = 100;
    public static int score { get; private set; }
    public static int playeHealth { get; private set; } = MAX_HEALTH;

    public static void UpdateScore(int deltaScore)
    {
        score += deltaScore;
    }

    public static void UpdateHealth(int deltaHealth)
    {
        playeHealth += deltaHealth;
    }

    public static void ResetLevel()
    {
        score = 0;
        playeHealth = MAX_HEALTH;
    }
}