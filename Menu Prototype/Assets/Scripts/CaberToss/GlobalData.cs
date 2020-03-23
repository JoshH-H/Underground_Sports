using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalData : MonoBehaviour
{
    static public int Scoring;
    public GameObject player;
    
    public Text scoreText;
    public Text scoreText2;
    public GameObject CountDownAnimation;
    public GameObject Instructions;

    void Awake()
    {
        SetDistance();
        Scoring = 0;
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

}