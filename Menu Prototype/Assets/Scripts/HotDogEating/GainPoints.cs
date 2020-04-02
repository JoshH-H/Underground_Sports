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

    public GameObject gold;
    public GameObject silver;
    public GameObject bronze;

    public GameObject Opp1;
    public GameObject Opp2;
    public GameObject Opp3;

    private void Start()
    {
        StartTime = Time.time;
    }
    private void Awake()
    {
        _dogs = 0;
        SetDogs();
        Opp1.GetComponent<Animator>().SetBool("Eat", true);
        Opp2.GetComponent<Animator>().SetBool("Eat", true);
        Opp3.GetComponent<Animator>().SetBool("Eat", true);
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
        float time = Time.time - StartTime;

        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

    }

    private void FixedUpdate()
    {
        StartCoroutine(twoMinutesFin());
    }

    private IEnumerator twoMinutesFin()
    {
        yield return new WaitForSeconds(120);
        Winningstates();
        Opp1.GetComponent<Animator>().SetBool("Eat", false);
        Opp2.GetComponent<Animator>().SetBool("Eat", false);
        Opp3.GetComponent<Animator>().SetBool("Eat", false);
    }

    void Winningstates()
    {
        if (_dogs >= 30)
        {
            gold.SetActive(true);
            Time.timeScale = 0;
        }

        if (_dogs >=25 && _dogs <30)
        {
            silver.SetActive(true);
            Time.timeScale = 0;
        }

        if (_dogs <= 24)
        {
            bronze.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
