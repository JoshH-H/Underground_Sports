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
        uSure.SetActive(false);
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

}
