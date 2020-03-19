using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PJGlobalData : MonoBehaviour
{
    public GameObject Player;
    public GameObject Driver;
    public GameObject Camera;
    public GameObject Goal;
    public GameObject Instructions;
    public GameObject CountDownAnimation;
    public GameObject GameOver;
    public GameObject Gold;
    public GameObject Silver;
    public GameObject Bronze;

    public GameObject[] pLives;

    static public int lives = 3;

    private Animator Animation;
    private RaceTimer Timer;
    private Rigidbody2D rb;

    private void Awake()
    {
        lives = 3;

        Animation = GetComponent<Animator>();
        rb = Player.GetComponent<Rigidbody2D>();
        Timer = GameObject.Find("Timer").GetComponent<RaceTimer>();

        Instructions.SetActive(true);
        CountDownAnimation.SetActive(false);
        Player.GetComponent<PacuJawiMovement>().enabled = false;
        Timer.enabled = false;
    }

    public void InstructionsComplete()
    {
        Instructions.SetActive(false);                
        CountDownAnimation.SetActive(true);

        StartCoroutine(ActivateMovement());
    }

    public void UpdateLives()
    {
        for (int i = 0; i < pLives.Length; i++)
        {
            if (lives > i)
            {
                pLives[i].SetActive(true);
            }
            else
            {
                pLives[i].SetActive(false);
            }
        }
        if (lives <= 0)
        {
            GameOverScene();
        }
    }

    public void GameOverScene()
    {
        GameOver.SetActive(true);
        Timer.enabled = false;

        Animation = Driver.GetComponent<Animator>();
        Animation.SetBool("GameOver", true);

        Driver.transform.parent = null;
        Camera.transform.parent = null;
    }

    private IEnumerator ActivateMovement()
    {
        yield return new WaitForSeconds(4);
        Player.GetComponent<PacuJawiMovement>().enabled = true;
        Timer.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Goal)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }

    /*    private void WinningStages()
        {
        if (Timer <= 0:26:00)
            {
                Gold
            }

        if (Timer <= 00:27:00 && >= 00:39:00)
            {
                Silver
            }

        if (Timer >= 00:40:00)
            {
                Silver
            }
        }*/
}
