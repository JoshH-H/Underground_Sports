using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text uiText;
    public float mainTimer;

    private float timer;
    private bool countDown = true;
    private bool doOnce = false;

    private void Start()
    {
        timer = mainTimer;
    }

    void Update()
    {
        if (timer >= 0 && countDown)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("f");
        }

        else if (timer <= 0 && !doOnce)
        {
            countDown = false;
            doOnce = true;
            uiText.text = "0";
            timer = 0;
        }
    }
}
