﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinAndRetryPJ : MonoBehaviour
{
    public void Retry()
    {
        Scene loadedLevel = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (loadedLevel.buildIndex);
    }
    
    public void Winner()
    {
        SceneManager.LoadScene ("LDScreen");
        PlayerPrefs.SetInt("levelReached", 4);
        PlayerPrefs.SetInt("_locks", 4);
    }

    public void Return()
    {
        SceneManager.LoadScene("LDScreen");
        PlayerPrefs.SetInt("levelReached", 3);
    }
}
