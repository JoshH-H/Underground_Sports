using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GainPoints : MonoBehaviour
{
    public static int _dogs;
    
    public Text dogText;
    public int point;

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
}
