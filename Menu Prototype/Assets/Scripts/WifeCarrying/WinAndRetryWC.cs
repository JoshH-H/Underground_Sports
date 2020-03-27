using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinAndRetryWC : MonoBehaviour
{
    public void Retry()
    {
        Scene loadedLevel = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (loadedLevel.buildIndex);
    }
    
    public void Winner()
    {
        SceneManager.LoadScene ("LDScreen");
    }

    public void Return()
    {
        SceneManager.LoadScene("LDScreen");
    }
    public void WinLevel()
    {
        PlayerPrefs.SetInt("levelReached", 3);
    }
}