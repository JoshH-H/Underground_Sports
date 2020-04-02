using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using UnityEngine.SceneManagement;

public class PlayPrefsTest : MonoBehaviour
{
    public Button[] levelButtons;
    public GameObject[] champion;
    public GameObject[] lockouts;
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

        int _locks = PlayerPrefs.GetInt("_locks", 1);
        
        for (int l = 0; l < lockouts.Length; l++)
        {
            if (l + 1 > _locks)
            {   
                lockouts[l].SetActive(true);
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
