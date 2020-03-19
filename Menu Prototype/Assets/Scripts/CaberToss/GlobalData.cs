using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalData : MonoBehaviour
{
    static public int Scoring;
    
    public Text scoreText;
    
    void Awake()
    {
        Scoring = 0;
        SetDistance();
    }
    
    public void SetDistance()
    {
        scoreText.text = Scoring.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
