using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown(3));
    }

    IEnumerator Countdown (int seconds)
    {
        int count = seconds;
        while (count > 0)
        {
            yield return new WaitForSeconds(1);
            count--;
        }
        StartGame();
    }

    void StartGame()
    {

    }
}
