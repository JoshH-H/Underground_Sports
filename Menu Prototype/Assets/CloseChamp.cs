using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseChamp : MonoBehaviour
{
    //public GameObject Champ;

     public void ChampClose()
    {
        //Champ.SetActive(false);        
        PlayerPrefs.SetInt("Champ", 1);
        SceneManager.LoadScene("LDScreen");
    }
}
