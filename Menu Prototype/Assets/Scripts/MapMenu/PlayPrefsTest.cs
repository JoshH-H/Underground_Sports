using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using UnityEngine.SceneManagement;

public class PlayPrefsTest : MonoBehaviour
{
    public Button[] levelButtons;
    public GameObject[] champion;
    public GameObject uSure;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            { 
                levelButtons[i].interactable = false;
            }
        }

        int Champ = PlayerPrefs.GetInt("Champ", 1);
        for (int c = 0; c < champion.Length; c++)
        {
            if (c + 1 > Champ)
            {
                champion[c].SetActive(false);
            }
        }
    }
    
    

    public void EraseData()
    {
        uSure.SetActive(true);
    }

    public void IAmSure()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("LDScreen");
    }

    public void NotSure()
    {
        uSure.SetActive(false);
    }

}
