using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDEGameMngr : MonoBehaviour
{
    public GameObject player;
    public GameObject CountDownAnimation;
    public GameObject Instructions;
    public GameObject Opp1;
    public GameObject Opp2;
    public GameObject Opp3;
    public GameObject OppScores;
    public GameObject OppScores0;
    Animator Animations;

    void Start()
    {
        Time.timeScale = 0;
        Animations = GetComponent<Animator>();
    }
    void Awake()
    {
        Instructions.SetActive(true);
        CountDownAnimation.SetActive(false);
        OppScores.SetActive(false);
        OppScores0.SetActive(true);
        player.GetComponent<GainPoints>().enabled = false;
        player.GetComponent<EatingFlow>().enabled = false;
        player.GetComponent<EatingTest>().enabled = false;

        Opp1.GetComponent<Animator>().SetBool("Eat",false);
        Opp2.GetComponent<Animator>().SetBool("Eat",false);
        Opp3.GetComponent<Animator>().SetBool("Eat",false);
    }

    public void InstructionsComplete()
    {
        Time.timeScale = 1;
        Instructions.SetActive(false);
        CountDownAnimation.SetActive(true);
        StartCoroutine(CountdownCompl());
    }

    private IEnumerator CountdownCompl()
    {
        yield return new WaitForSeconds(4);
        player.GetComponent<GainPoints>().enabled = true;
        player.GetComponent<EatingFlow>().enabled = true;
        player.GetComponent<EatingTest>().enabled = true;
        Opp1.GetComponent<Animator>().SetBool("Eat", true);
        Opp2.GetComponent<Animator>().SetBool("Eat", true);
        Opp3.GetComponent<Animator>().SetBool("Eat", true);
        OppScores.SetActive(true);
        OppScores0.SetActive(false);
    }
}
