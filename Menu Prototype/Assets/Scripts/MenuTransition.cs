using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTransition : MonoBehaviour
{ 
    public void Begin()
    {
        SceneManager.LoadScene("LDScreen");
    }

    public void quit()
    {
        Application.Quit();
    }
}
