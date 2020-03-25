using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingTest : MonoBehaviour
{
    public GameObject Player;
    private Animator Animation;


    // Start is called before the first frame update
    void Start()
    {
        Animation = Player.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Animation.SetBool("Eat", true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Animation.SetBool("Drink", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animation.SetBool("Burp", true);
        }

        if (!Input.anyKey)
        {
            Animation.SetBool("Drink", false);
            Animation.SetBool("Eat", false);
            Animation.SetBool("Burp", false);
        }
    }
}
