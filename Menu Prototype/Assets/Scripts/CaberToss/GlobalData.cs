using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalData : MonoBehaviour
{
    static public int Scoring;
    public GameObject player;
    /*static public int Lives = 3;
    public GameObject[] pLives;*/
    
    public Text scoreText;
    public Text scoreText2;
    
    void Awake()
    {
        SetDistance();
        Scoring = 0;
        /*Lives = 3;*/
    }
    
    public void SetDistance()
    {
        scoreText.text = Scoring.ToString();
        scoreText2.text = Scoring.ToString();
    }

    /*public void UpdateLives()
    {
        for (int i = 0; i < pLives.Length; i++)
        {
            if (Lives > i)
            {
                pLives[i].SetActive(true);
            }
            else
            {
                pLives[i].SetActive(false);
            }
        }
        if (Lives <= 0)
        {
            //EndGame();
        }
    }*/
}
