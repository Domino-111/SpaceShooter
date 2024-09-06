using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text timerText;
    float timer;

    public static int score;

    public static GameManager gm;

    public bool playing;

    void Start()
    {
        gm = this;

        timer = 0;
        score = 0;

        UpdateScore();

        playing = true;
    }

    void Update()
    {
        if (playing)
        {
            timer += Time.deltaTime;
            timerText.text = "Time: " + Mathf.Round(timer * 10) / 10 + "s";
        }
    }

    public void UpdateScore()
    {
        scoreText.text = "Asteroids Hit: " + score;
    }
}
