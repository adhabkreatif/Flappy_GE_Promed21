using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystemScript : MonoBehaviour
{
    public static ScoreSystemScript instance;

    [SerializeField] TMP_Text scoreText;

    [HideInInspector] public int scoreAmount = 0;

    private void Start()
    {
        scoreAmount = 0;
        scoreText.text = scoreAmount.ToString();
        instance = this;
    }

    public void AddScore()
    {
        scoreAmount += 1;
        UpdateScoreText();

        if (scoreAmount % 5 == 0)
        {
            ShootScript.instance.AddShoot(1);
        }
    }

    public void UpdateScoreText()
    {
        scoreText.text = scoreAmount.ToString();
    }
}
