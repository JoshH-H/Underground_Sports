using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouLose : MonoBehaviour
{
    public GameObject Lose;
    public GameObject Player;
    private Animator Animation;
    void Start()
    {
        Animation = Player.GetComponent<Animator>();
        Animation.SetBool("Drink", false);
        Animation.SetBool("Eat", false);
        Animation.SetBool("Burp", false);
        Lose.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        Animation.SetBool("Barf", true);
    }

    public void barfLose()
    {
        Lose.SetActive(true);
        Time.timeScale = 0;
    }
}
