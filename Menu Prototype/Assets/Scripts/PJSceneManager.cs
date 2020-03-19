using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJSceneManager : MonoBehaviour
{
    public GameObject Goal;

    Rigidbody2D rb;
    Animator animState;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb = GetComponent<Rigidbody2D>();

        if (collision.gameObject == Goal)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            //animState == idle;
        }
    }

}
