using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TunaScoring : MonoBehaviour
{
    public int value = 0;
    public GameObject distance;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fish")
        {
            distance.SetActive(true);
            /*GlobalData.Lives--;
            GameObject.Find("GameBoss").GetComponent<GlobalData>().UpdateLives();*/
        }
    }
    
}