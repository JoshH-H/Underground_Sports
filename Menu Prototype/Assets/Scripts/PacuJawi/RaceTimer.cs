using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceTimer : MonoBehaviour
{
    public Text timerText;
    private float StartTime;

    private void Start()
    {
        StartTime = Time.time;
    }

    void Update()
    {
        float time = Time.time - StartTime;

        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
}
