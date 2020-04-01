using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaberRun : MonoBehaviour
{
    private float HorizontalMoveSpeed = 0.01f;
    public bool canMove = true;
    public Vector3 startPosition;

    private Animator Animation;

     void Start()
    {

    }

    void Update()
    {
        movement();
        StartCoroutine (Animations());
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * HorizontalMoveSpeed;
            //character movement
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == ("StopMoving"))
        {
            HorizontalMoveSpeed = 0f;
            Debug.Log("hti");
        }
        Debug.Log("smash");
    }
    


    public IEnumerator Animations()
    {
        Animation = GetComponent<Animator>();

        if (Input.anyKey)
        {
            Animation.SetBool("Moving", true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Animation.SetBool("Tossed", true);
            yield return new WaitForSeconds(2);
            Animation.SetBool("Relax", true);
        }

        if (!Input.anyKey)
        {
            Animation.SetBool("Moving", false);
        }
    }
}