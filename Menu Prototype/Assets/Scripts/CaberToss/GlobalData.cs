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
    public GameObject CountDownAnimation;
    public GameObject Instructions;

    void Awake()
    {
        SetDistance();
        Scoring = 0;
        /*Lives = 3;*/

        Instructions.SetActive(true);
        CountDownAnimation.SetActive(false);
        player.GetComponent<CaberRun>().enabled = false;
    }
    
    public void SetDistance()
    {
        scoreText.text = Scoring.ToString();
        scoreText2.text = Scoring.ToString();
    }

    public void InstructionsComplete()
    {
        Instructions.SetActive(false);
        CountDownAnimation.SetActive(true);
        StartCoroutine(CountdownCompl());
    }

    private IEnumerator CountdownCompl()
    {
        yield return new WaitForSeconds(4);
        player.GetComponent<CaberRun>().enabled = true;
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