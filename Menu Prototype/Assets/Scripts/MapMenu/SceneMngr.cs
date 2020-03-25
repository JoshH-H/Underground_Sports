using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMngr : MonoBehaviour
{
    public void CT()
    {
        SceneManager.LoadScene("CaberToss");
    }

    public void WC()
    {
        SceneManager.LoadScene("WifeCarrying");
    }

    public void PJ()
    {
        SceneManager.LoadScene("PacuJawiPrototype");
    }

    public void TT()
    {
        SceneManager.LoadScene("TunaTossScene");
    }

    public void HDE()
    {
        SceneManager.LoadScene("HotDogEatingScene");
    }
}
