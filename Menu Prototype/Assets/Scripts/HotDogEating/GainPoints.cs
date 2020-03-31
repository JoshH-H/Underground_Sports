using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainPoints : MonoBehaviour
{
    public int _dogs;
    public GameObject Winner;
    
    public Text dogText;
    public int point;
    public Text timerText;
    private float StartTime;
    

    private void Start()
    {
        StartTime = Time.time;
    }
    private void Awake()
    {
        _dogs = 0;
        SetDogs();
    }
    public void SetDogs()
    {
        dogText.text = _dogs.ToString();
    }

    public void EatADog()
    {
        _dogs += point;
        SetDogs();
    }

     void Update()
    {
        if (_dogs == 20)
        {
            Winner.SetActive(true);
            Time.timeScale = 0;
        }
        
        float time = Time.time - StartTime;

        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

    }
}
