using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;

    public TMP_Text highScore;
    public ScoreManager scoreManager;
    private float hScore;

    private void Update()
    {
        scoreText.text = scoreManager.score.ToString();

    }
}
