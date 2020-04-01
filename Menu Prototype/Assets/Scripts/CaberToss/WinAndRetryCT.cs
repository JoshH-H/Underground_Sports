using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinAndRetryCT : MonoBehaviour
{
    public void Retry()
    {
        Scene loadedLevel = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (loadedLevel.buildIndex);
    }
    
    public void Winner()
    {
        SceneManager.LoadScene ("LDScreen");
        PlayerPrefs.SetInt("levelReached", 2);
    }

    public void Return()
    {
        SceneManager.LoadScene("LDScreen");
        
    }
}
