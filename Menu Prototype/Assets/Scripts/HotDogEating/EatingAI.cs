using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingAI : MonoBehaviour
{
    private Animator Animation;
    public GameObject Player;
    public bool GameActive;
    // Start is called before the first frame update
    void Start()
    {
        Animation = GetComponent<Animator>();
        GameActive = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(EatDrinkIdle());
    }

    private IEnumerator EatDrinkIdle()
    {
        while (GameActive == true)
        {
            yield return new WaitForSeconds(2);
            Animation.SetBool("Idle", false);
            Animation.SetBool("Eat", true);
            yield return new WaitForSeconds(4);
            Animation.SetBool("Eat", false);
            Animation.SetBool("Drink", true);
            yield return new WaitForSeconds(3);
            Animation.SetBool("Drink", false);
            Animation.SetBool("Idle", true);
        }
       
    }
}
