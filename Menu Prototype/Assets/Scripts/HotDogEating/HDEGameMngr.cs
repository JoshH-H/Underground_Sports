using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDEGameMngr : MonoBehaviour
{
    public GameObject player;
    public GameObject CountDownAnimation;
    public GameObject Instructions;

    void Awake()
    {
        Instructions.SetActive(true);
        CountDownAnimation.SetActive(false);
        player.GetComponent<GainPoints>().enabled = false;
    }

    public void InstructionsComplete()
    {
        Instructions.SetActive(false);
        CountDownAnimation.SetActive(true);
        StartCoroutine(CountdownCompl());
    }

    private IEnumerator CountdownCompl()
    {
        yield return new WaitForSeconds(4);
        player.GetComponent<GainPoints>().enabled = true;
    }
}
