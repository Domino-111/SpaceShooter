using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timerText;
    float timer;

    public static GameManager gm;

    public bool playing;

    void Start()
    {
        gm = this;

        timer = 0f;

        playing = true;
    }

    void Update()
    {
        if (playing)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString();
        }
    }
}
