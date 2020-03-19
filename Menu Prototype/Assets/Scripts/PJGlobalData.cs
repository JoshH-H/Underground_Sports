using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJGlobalData : MonoBehaviour
{
    public GameObject Player;
    static public int lives = 3;

    public GameObject[] pLives;

    // Start is called before the first frame update
    private void Awake()
    {
        lives = 3;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            //EndGame();
        }
    }
}
