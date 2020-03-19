using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJObstacles : MonoBehaviour
{
    public GameObject obstacle;
    PJGlobalData gd;
    Rigidbody2D rb;

    void Start()
    {
        gd = GameObject.Find("GameManager").GetComponent<PJGlobalData>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            PJGlobalData.lives--;
            GameObject.Find("GameManager").GetComponent<PJGlobalData>().UpdateLives();
        }
    }

    private void DisableMovement()
    {

    }
}